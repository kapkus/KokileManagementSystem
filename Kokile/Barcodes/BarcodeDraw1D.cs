using System.Drawing;
using System.Drawing.Drawing2D;

namespace Kokile
{
    public partial class BarcodeCreator1D
    {

        protected void GenerateBarcodeShort(string barcodeNumber)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap1D))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                currentPosX += 5;
                DrawStartEndRect(graphics);
                for (int i = 1; i <= 8; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyRect(graphics);
                    }
                    else
                    {
                        DrawFilledRect(graphics);
                    }
                }
                DrawSectionRect(graphics);
                for (int i = 10; i <= 16; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyRect(graphics);
                    }
                    else
                    {
                        DrawFilledRect(graphics);
                    }
                }
                DrawStartEndRect(graphics);
            }
            currentPosX = 0;
        }

        protected void GenerateBarcodeLong(string barcodeNumber)
        {
            using (Graphics graphics = Graphics.FromImage(bitmap1D))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                currentPosX += 5;
                DrawStartEndRect(graphics);
                for (int i = 1; i <= 8; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyRect(graphics);
                    }
                    else
                    {
                        DrawFilledRect(graphics);
                    }
                }
                DrawSectionRect(graphics);
                for (int i = 10; i <= 12; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyRect(graphics);
                    }
                    else
                    {
                        DrawFilledRect(graphics);
                    }
                }
                DrawSectionRect(graphics);
                for (int i = 14; i <= 20; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyRect(graphics);
                    }
                    else
                    {
                        DrawFilledRect(graphics);
                    }
                }
                DrawStartEndRect(graphics);
            }
            currentPosX = 0;
        }

        protected static void DrawStartEndRect(Graphics graphics)
        {
            graphics.FillRectangle(fillBrush, currentPosX, currentPosY, 26, barcodeHeight + 1);
            currentPosX += 11 + 26;
        }

        protected void DrawSectionRect(Graphics graphics)
        {
            graphics.FillRectangle(fillBrush, currentPosX, currentPosY, 24, barcodeHeight + 1);
            currentPosX += 11 + 24;
        }

        protected void DrawFilledRect(Graphics graphics)
        {
            graphics.FillRectangle(fillBrush, currentPosX, currentPosY, 13, barcodeHeight + 1);
            currentPosX += 11 + 13;
        }

        protected void DrawEmptyRect(Graphics graphics)
        {
            graphics.DrawRectangle(outlinePen, currentPosX, currentPosY, 13, barcodeHeight);
            currentPosX += 11 + 13;
        }
    }
}
