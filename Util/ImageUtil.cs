
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
namespace BookingManagement.Util
{
    internal class ImageUtil
    {
        public static Image HoverImage(Image image)
        {
            return ImageUtil.DimmedImage(ImageUtil.RoundCorner(image, 30), 20);
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

        public static Image RoundCorner(Image image, float roundnessPercentage)
        {
            if (image == null) return null;

            int roundness = (int)(Math.Min(image.Width, image.Height) * roundnessPercentage / 100);
            var roundedImage = new Bitmap(image.Width, image.Height);

            using (var graphics = Graphics.FromImage(roundedImage))
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var path = new GraphicsPath();

                // Top-left corner
                path.AddArc(0, 0, roundness, roundness, 180, 90);
                // Top-right corner
                path.AddArc(image.Width - roundness, 0, roundness, roundness, 270, 90);
                // Bottom-right corner
                path.AddArc(image.Width - roundness, image.Height - roundness, roundness, roundness, 0, 90);
                // Bottom-left corner
                path.AddArc(0, image.Height - roundness, roundness, roundness, 90, 90);
                path.CloseFigure();

                graphics.Clear(Color.Transparent);

                using (var brush = new TextureBrush(image))
                {
                    graphics.FillPath(brush, path);
                }
            }

            return roundedImage;
        }


        public static string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                using (Image clonedImage = new Bitmap(image))
                {
                    clonedImage.Save(ms, format);
                }
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public static Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms);
                return image;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error converting Base64 to Image: {ex.Message}");
                return null;
            }
        }
    }
}
