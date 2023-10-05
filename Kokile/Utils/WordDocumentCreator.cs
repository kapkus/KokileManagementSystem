using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using A = DocumentFormat.OpenXml.Drawing;

namespace Kokile
{
    public class WordDocumentCreator
    {

        public static string templatePath;
        public static string outputPath;

        public WordDocumentCreator()
        {
            templatePath = @"data\templateKokila.docx";
            outputPath = @"data\kokila.docx";
        }

        public void InsertFormData(Dictionary<string, object> variableValues)
        {
            try 
            {
                File.Copy(templatePath, outputPath, true);
                using (WordprocessingDocument doc = WordprocessingDocument.Open(outputPath, true))
                {
                    MainDocumentPart mainPart = doc.MainDocumentPart;
                    var body = mainPart.Document.Body;

                    foreach (SdtElement contentControl in mainPart.Document.Descendants<SdtElement>())
                    {
                        Tag tag = contentControl.Descendants<Tag>().FirstOrDefault();

                        if (tag != null && variableValues.ContainsKey(tag.Val))
                        {
                            object value = variableValues[tag.Val];

                            if (value is string)
                            {
                                // Replace the content control with the string value
                                string textValue = (string)value;
                                insertText(contentControl, textValue);
                            }
                            else if (value is Bitmap)
                            {
                                // Replace the content control with the bitmap image
                                Bitmap bitmap = (Bitmap)value;

                                insertBitmap(contentControl, mainPart, bitmap);
                            }
                        }
                    }
                    mainPart.Document.Save();
                }
            }
            catch(IOException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            



        }

        private void insertText(SdtElement contentControl, string textValue)
        {
            Run run = contentControl.Descendants<Run>().FirstOrDefault();
            if (run != null)
            {
                Text text = run.Descendants<Text>().FirstOrDefault();
                if (text != null)
                    text.Text = textValue;
            }
        }

        private void insertBitmap(SdtElement contentControl, MainDocumentPart mainPart, Bitmap bitmap)
        {
            // Replace the image in the content control
            A.Blip blip = contentControl.Descendants<A.Blip>().FirstOrDefault();
            if (blip != null)
            {
                string existingImageId = blip.Embed;
                if (!string.IsNullOrEmpty(existingImageId))
                {
                    // Delete the existing image part
                    var existingImagePart = mainPart.GetPartsOfType<ImagePart>()
                                                    .FirstOrDefault(part => mainPart.GetIdOfPart(part) == existingImageId);
                    if (existingImagePart != null)
                        mainPart.DeletePart(existingImagePart);
                }

                // Create a new relationship ID for the image
                string imageRelId = "imageId" + Guid.NewGuid().ToString("N");
                ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg, imageRelId);
                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Jpeg);
                    stream.Seek(0, SeekOrigin.Begin);
                    imagePart.FeedData(stream);
                }

                // Set the image relationship ID
                blip.Embed = mainPart.GetIdOfPart(imagePart);

                // Update the size of the picture
                Drawing drawing = contentControl.Parent as Drawing;
                if (drawing != null)
                {
                    Inline inline = drawing.Parent as Inline;
                    if (inline != null)
                    {
                        var extent = inline.Descendants<Extent>().FirstOrDefault();
                        if (extent != null)
                        {
                            extent.Cx = bitmap.Width * 9525;
                            extent.Cy = bitmap.Height * 9525;
                        }
                    }
                }
            }
        }
    }
}