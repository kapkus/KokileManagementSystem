using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Kokile
{
    public partial class BarcodeCreator1D
    {
        protected static Bitmap bitmap1D;
        protected static int bitmapSizeX;
        protected static int bitmapSizeY;
        protected static int currentPosX;
        protected static int currentPosY;
        protected static int barcodeHeight;
        protected string barcodeNumber;
        protected static Brush fillBrush;
        protected static Pen outlinePen;

        public BarcodeCreator1D(string barcodeNumber)
        {
            this.barcodeNumber = barcodeNumber;
            bitmapSizeX = 580;
            bitmapSizeY = 80;
            currentPosX = 0;
            currentPosY = 10;
            barcodeHeight = 60;
            fillBrush = Brushes.Black;
            outlinePen = new Pen(Color.Black, 1);

            bitmap1D = CreateBlankBitmap();

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

        virtual public void DrawBarcode()
        {
            if (this.barcodeNumber.Length == 18)
            {
                currentPosX += 45;
                GenerateBarcodeShort(this.barcodeNumber);
            }
            else if (this.barcodeNumber.Length == 22)
            {
                GenerateBarcodeLong(this.barcodeNumber);
            }
            else
            {
                MessageBox.Show("Nieprawidłowy kod kreskowy.");
            }
        }

        public Bitmap GetBitmap()
        {
            return bitmap1D;
        }
    }
}
