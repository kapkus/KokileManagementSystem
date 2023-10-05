using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Kokile
{
    class BarcodeFinder : BarcodeCreator1D
    {
        private struct RectCords
        {
            public int index;
            public int start;
            public int end;
            public bool editable;
        }

        private RectCords[] rectArray;
        private PictureBox pBox;
        public BarcodeFinder(PictureBox pBox, string barcodeNumber = "1100010001010100010001") : base(barcodeNumber)
        {
            bitmapSizeX = 580;
            bitmapSizeY = 80;

            this.pBox = pBox;
            this.barcodeNumber = barcodeNumber;
            this.pBox.Width = bitmapSizeX;
            this.pBox.Height = bitmapSizeY;

            ArrangeRectCords();

            bitmap1D = CreateBlankBitmap();
            this.pBox.Image = GetBitmap();
            DrawBarcode();
        }

        public override void DrawBarcode() 
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

        public string CalculateClickedRectangleIndex(int x)
        {

            RectCords foundRect = this.rectArray.FirstOrDefault(rect => x >= rect.start && x <= rect.end);
            if (foundRect.editable)
            {
                char currentValue = barcodeNumber[foundRect.index];
                char newValue = currentValue == '0' ? '1' : '0';
                this.barcodeNumber = barcodeNumber.Remove(foundRect.index, 1).Insert(foundRect.index, newValue.ToString());

                Debug.WriteLine($"Changed barcodeNumber: {barcodeNumber}");
            }

            bitmap1D = CreateBlankBitmap();
            DrawBarcode();
            this.pBox.Image = GetBitmap();
            return this.barcodeNumber;
        }


        private void ArrangeRectCords()
        {
            if (this.barcodeNumber.Length == 22)
            {
                rectArray = new RectCords[] {
                new RectCords { index = 0, start = 5, end = 31, editable = false },
                new RectCords { index = 1, start = 42, end = 55, editable = true },
                new RectCords { index = 2, start = 66, end = 79, editable = true },
                new RectCords { index = 3, start = 90, end = 103, editable = true },
                new RectCords { index = 4, start = 114, end = 127, editable = true },
                new RectCords { index = 5, start = 138, end = 151, editable = true },
                new RectCords { index = 6, start = 162, end = 175, editable = true },
                new RectCords { index = 7, start = 186, end = 199, editable = true },
                new RectCords { index = 8, start = 210, end = 223, editable = true },
                new RectCords { index = 9, start = 234, end = 258, editable = false },
                new RectCords { index = 10, start = 269, end = 282, editable = true },
                new RectCords { index = 11, start = 293, end = 306, editable = true },
                new RectCords { index = 12, start = 317, end = 330, editable = true },
                new RectCords { index = 13, start = 341, end = 365, editable = false },
                new RectCords { index = 14, start = 376, end = 389, editable = true },
                new RectCords { index = 15, start = 400, end = 413, editable = true },
                new RectCords { index = 16, start = 424, end = 437, editable = true },
                new RectCords { index = 17, start = 448, end = 461, editable = true },
                new RectCords { index = 18, start = 472, end = 485, editable = true },
                new RectCords { index = 19, start = 496, end = 509, editable = true },
                new RectCords { index = 20, start = 520, end = 533, editable = true },
                new RectCords { index = 21, start = 544, end = 570, editable = false },
                };
            }
            else if (this.barcodeNumber.Length == 18) 
            {
                rectArray = new RectCords[] {
                new RectCords { index = 0, start = 50, end = 76, editable = false },
                new RectCords { index = 1, start = 87, end = 100, editable = true },
                new RectCords { index = 2, start = 111, end = 124, editable = true },
                new RectCords { index = 3, start = 135, end = 148, editable = true },
                new RectCords { index = 4, start = 159, end = 172, editable = true },
                new RectCords { index = 5, start = 183, end = 196, editable = true },
                new RectCords { index = 6, start = 207, end = 220, editable = true },
                new RectCords { index = 7, start = 231, end = 244, editable = true },
                new RectCords { index = 8, start = 255, end = 268, editable = true },
                new RectCords { index = 9, start = 279, end = 303, editable = false },
                new RectCords { index = 10, start = 314, end = 327, editable = true },
                new RectCords { index = 11, start = 338, end = 351, editable = true },
                new RectCords { index = 12, start = 362, end = 375, editable = true },
                new RectCords { index = 13, start = 386, end = 399, editable = true },
                new RectCords { index = 14, start = 410, end = 423, editable = true },
                new RectCords { index = 15, start = 434, end = 447, editable = true },
                new RectCords { index = 16, start = 458, end = 471, editable = true },
                new RectCords { index = 17, start = 482, end = 508, editable = false }
                };
            }
            
        }
    }
}
