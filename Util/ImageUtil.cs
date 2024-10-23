
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace BookingManagement.Util
{
    internal class ImageUtil
    {
        public static Image HoverImage(Image image)
        {
            return ImageUtil.DimmedImage(ImageUtil.RoundCorner(image, 30), 10);
        }
        public static Image ResizeImage(Image image, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        public static Image DimmedImage(Image image, int dimness)
        {
            float dimFactor = 1f - dimness / 100f;  
            var colorMatrix = new ColorMatrix(new float[][]
            {
            new float[] {dimFactor, 0, 0, 0, 0},
            new float[] {0, dimFactor, 0, 0, 0},
            new float[] {0, 0, dimFactor, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {0, 0, 0, 0, 1}
            });

            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(colorMatrix);

            var dimmedImage = new Bitmap(image.Width, image.Height);
            using (var graphics = Graphics.FromImage(dimmedImage))
            {
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            return dimmedImage;
        }

        public static Image RoundCorner(Image image, int roundness)
        {
            var roundedImage = new Bitmap(image.Width, image.Height);
            using (var graphics = Graphics.FromImage(roundedImage))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var path = new GraphicsPath();
                path.AddArc(0, 0, roundness, roundness, 180, 90); // Top-left corner
                path.AddArc(image.Width - roundness, 0, roundness, roundness, 270, 90); // Top-right corner
                path.AddArc(image.Width - roundness, image.Height - roundness, roundness, roundness, 0, 90); // Bottom-right corner
                path.AddArc(0, image.Height - roundness, roundness, roundness, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Clear the image with a transparent background
                graphics.Clear(Color.Transparent);

                // Set the clipping region to the rounded rectangle
                using (var brush = new TextureBrush(image))
                {
                    graphics.FillPath(brush, path);
                }
            }
            return roundedImage;
        }
    }
}
