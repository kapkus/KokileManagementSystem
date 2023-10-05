using System.Drawing;
using System.Drawing.Drawing2D;

namespace Kokile
{
    public partial class BarcodeCreator2D
    {
        private static void GenerateFirstVariantLong(string barcodeNumber)
        {
            using (Graphics graphics = Graphics.FromImage(bitmapFirstVariant))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawStart(graphics, blackPenBold);
                // ============================ Draw start section
                DrawStraightLine(graphics, blackPen);
                for (int i = 1; i <= 8; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawShortHill(graphics, blackPen);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPen);
                }
                // ============================ Draw middle section
                DrawMiddleHill(graphics, blackPenBold);
                DrawStraightLine(graphics, blackPen);
                for (int i = 10; i <= 12; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawShortHill(graphics, blackPen);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPen);
                }
                DrawMiddleHill(graphics, blackPenBold);
                // ============================ Draw end section
                DrawStraightLine(graphics, blackPen);
                for (int i = 14; i <= 20; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawShortHill(graphics, blackPen);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPen);
                }
                DrawEnd(graphics, blackPenBold);

            }
            currentPosX = 0;
        }

        private void GenerateSecondVariantLong(string barcodeNumber)
        {
            using (Graphics graphics = Graphics.FromImage(bitmapSecondVariant))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawStart(graphics, blackPenBold);
                // ============================ Draw start section
                DrawStraightLine(graphics, blackPenBold);
                for (int i = 1; i <= 8; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyHillLine(graphics, blackPenBold);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPenBold);
                }
                // ============================ Draw middle section
                DrawMiddleHill(graphics, blackPenBold);
                DrawStraightLine(graphics, blackPenBold);
                for (int i = 10; i <= 12; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyHillLine(graphics, blackPenBold);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPenBold);
                }
                DrawMiddleHill(graphics, blackPenBold);
                // ============================ Draw end section
                DrawStraightLine(graphics, blackPenBold);
                for (int i = 14; i <= 20; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyHillLine(graphics, blackPenBold);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPenBold);
                }
                DrawEnd(graphics, blackPenBold);

            }
            currentPosX = 0;
        }

        private void GenerateFirstVariantShort(string barcodeNumber)
        {
            using (Graphics graphics = Graphics.FromImage(bitmapFirstVariant))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawStart(graphics, blackPenBold);
                // ============================ Draw start section
                DrawStraightLine(graphics, blackPen);
                for (int i = 1; i <= 8; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawShortHill(graphics, blackPen);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPen);
                }
                // ============================ Draw middle section
                DrawMiddleHill(graphics, blackPenBold);
                // ============================ Draw end section
                DrawStraightLine(graphics, blackPen);
                for (int i = 10; i <= 16; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawShortHill(graphics, blackPen);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPen);
                }
                DrawEnd(graphics, blackPenBold);

            }
            currentPosX = 0;
        }

        private void GenerateSecondVariantShort(string barcodeNumber)
        {
            using (Graphics graphics = Graphics.FromImage(bitmapSecondVariant))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawStart(graphics, blackPenBold);
                // ============================ Draw start section
                DrawStraightLine(graphics, blackPenBold);
                for (int i = 1; i <= 8; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyHillLine(graphics, blackPenBold);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPenBold);
                }
                // ============================ Draw middle section
                DrawMiddleHill(graphics, blackPenBold);
                // ============================ Draw end section
                DrawStraightLine(graphics, blackPenBold);
                for (int i = 10; i <= 16; i++)
                {
                    if (barcodeNumber[i] == '0')
                    {
                        DrawEmptyHillLine(graphics, blackPenBold);
                    }
                    else
                    {
                        DrawShortHill(graphics, blackPenBold);
                    }
                    DrawStraightLine(graphics, blackPenBold);
                }
                DrawEnd(graphics, blackPenBold);

            }
            currentPosX = 0;
        }

        

        private static void DrawStart(Graphics graphics, Pen pen)
        {
            Point[] points = new Point[] {
                new Point(currentPosX, currentPosY),
                new Point(currentPosX += 5, currentPosY),
                new Point(currentPosX, currentPosY),
                new Point(currentPosX += 2, currentPosY- hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 22, currentPosY - hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 2, currentPosY),
                new Point(currentPosX, currentPosY),
            };
            graphics.DrawLines(pen, points);

        }

        private static void DrawMiddleHill(Graphics graphics, Pen pen)
        {
            Point[] points = new Point[] {
                new Point(currentPosX, currentPosY),
                new Point(currentPosX += 2, currentPosY- hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 20, currentPosY - hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 2, currentPosY),
                new Point(currentPosX, currentPosY),
            };
            graphics.DrawLines(pen, points);
        }

        private static void DrawShortHill(Graphics graphics, Pen pen)
        {
            Point[] points = new Point[] {
                new Point(currentPosX, currentPosY),
                new Point(currentPosX += 2, currentPosY- hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 9, currentPosY - hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 2, currentPosY),
                new Point(currentPosX, currentPosY),
            };
            graphics.DrawLines(pen, points);
        }

        private static void DrawEnd(Graphics graphics, Pen pen)
        {
            Point[] points = new Point[] {
                new Point(currentPosX, currentPosY),
                new Point(currentPosX += 2, currentPosY- hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 22, currentPosY - hillHeight),
                new Point(currentPosX, currentPosY - hillHeight),
                new Point(currentPosX += 2, currentPosY),
                new Point(currentPosX, currentPosY),
                new Point(currentPosX, currentPosY),
                new Point(currentPosX += 5, currentPosY),
            };
            graphics.DrawLines(pen, points);
        }

        private static void DrawStraightLine(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, new Point(currentPosX, currentPosY), new Point(currentPosX += 11, currentPosY));
        }

        private static void DrawEmptyHillLine(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, new Point(currentPosX, currentPosY), new Point(currentPosX += 13, currentPosY));
        }
    }
}
