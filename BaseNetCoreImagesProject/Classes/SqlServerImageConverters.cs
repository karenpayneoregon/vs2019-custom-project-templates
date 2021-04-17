using System.Drawing;
using System.IO;

namespace BaseNetCoreImagesProject.Classes
{
    /// <summary>
    /// Image helpers to convert values read from SQL-Server to images
    /// </summary>
    public class SqlServerImageConverters
    {

        /// <summary>
        /// Convert byte array from Image column to Image
        /// </summary>
        /// <param name="contents"></param>
        /// <returns></returns>
        public static Image ByteArrayFromImageToImage(byte[] contents)
        {
            using var ms = new MemoryStream(contents);
            return Image.FromStream(ms);
        }

        /// <summary>
        /// Convert byte array from varbinary(max) to Image
        /// </summary>
        /// <param name="contents"></param>
        /// <returns></returns>
        public static Image ByteArrayFromVarBinaryToImage(byte[] contents)
        {
            var converter = new ImageConverter();
            var image = (Image)converter.ConvertFrom(contents);

            return image;
        }
    }
}