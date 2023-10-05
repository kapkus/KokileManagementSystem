using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Kokile
{
    public partial class BarcodeCreator2D
    {
        private static Bitmap bitmapFirstVariant;
        private static Bitmap bitmapSecondVariant;
        private static int bitmapSizeX;
        private static int bitmapSizeY;
        private static int currentPosX;
        private static int currentPosY;
        private static int hillHeight;
        private static Pen blackPen;
        private static Pen blackPenBold;
        private string barcodeNumber;

        public BarcodeCreator2D(string barcodeNumber)
        {
            this.barcodeNumber = barcodeNumber;
            bitmapSizeX = 580;
            bitmapSizeY = 40;
            currentPosX = 0;
            currentPosY = 30;
            hillHeight = 10;

            bitmapFirstVariant = CreateBlankBitmap();
            bitmapSecondVariant = CreateBlankBitmap();

            blackPen = new Pen(Color.Black, 1);
            blackPenBold = new Pen(Color.Black, 3);
        }

        public static Bitmap CreateBlankBitmap()
        {
            Bitmap generatedBitmap;
            int width = bitmapSizeX;
            int height = bitmapSizeY;

            generatedBitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(generatedBitmap))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.Clear(Color.White);
            }

            return generatedBitmap;
        }

        public void DrawBarcodes()
        {
            if (this.barcodeNumber.Length == 18)
            {
                currentPosX += 45;
                GenerateFirstVariantShort(this.barcodeNumber);
                currentPosX += 45;
                GenerateSecondVariantShort(this.barcodeNumber);
            }
            else if (this.barcodeNumber.Length == 22)
            {
                GenerateFirstVariantLong(this.barcodeNumber);
                GenerateSecondVariantLong(this.barcodeNumber);
            }
            else 
            {
                MessageBox.Show("Nieprawidłowy kod kreskowy.");
            }
        }

        public Bitmap getFirstBitmap()
        {
            return bitmapFirstVariant;
        }

        public Bitmap getSecondBitmap()
        {
            return bitmapSecondVariant;
        }

    }
}
