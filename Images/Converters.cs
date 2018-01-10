using System.Drawing;

namespace Images
{
    public static class Converters
    {
        public static Bitmap make_bw(this Bitmap original)
        {
            return original.make_bw(200);
        }

        public static Bitmap make_bw(this Bitmap original, int avg)
        {
            if (original == null)
                return null;

            var output = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {

                for (int j = 0; j < original.Height; j++)
                {

                    Color c = original.GetPixel(i, j);

                    int average = ((c.R + c.B + c.G) / 3);

                    output.SetPixel(i, j, average < avg ? Color.Black : Color.White);
                }
            }

            return output;

        }

        public static bool[,] GetMaskResized(this Bitmap image, int avg)
        {
            var scale = image.Height > image.Width ? image.Height : image.Width;
            var resized = new Bitmap(image, new Size(scale, scale));
            return resized.GetMask(avg);
        }

        public static bool[,] GetMask(this Bitmap image, int avg)
        {
            var output = new bool[image.Width, image.Height];

            for (int i = 0; i < image.Width; i++)
            {

                for (int j = 0; j < image.Height; j++)
                {

                    var c = image.GetPixel(i, j);

                    var average = ((c.R + c.B + c.G) / 3);

                    output[i, j] = average < avg;
                }
            }

            return output;
        }
    }
}
