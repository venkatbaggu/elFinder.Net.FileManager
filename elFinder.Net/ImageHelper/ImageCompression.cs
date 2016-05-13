using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace elFinder.ImageHelper
{
   public class ImageCompression
   {
       private Image OriginalImage;
       public void CompressImage(Image image, string filePath)
       {
           try
           {
               ImageConverter converter = new ImageConverter();
               byte[] data = (byte[])converter.ConvertTo(image, typeof(byte[]));                         
               using (var ms = new MemoryStream(data))
               {
                   Bitmap bmp = new Bitmap(Image.FromStream(ms));
                   OriginalImage = bmp;
               }

                SaveJpg(OriginalImage, filePath, 50);
           }
           catch (Exception ex)
           {
             
           }
       }

        public void CompressImageBytes(byte[] image, string filePath)
        {
            try
            {
                //ImageConverter converter = new ImageConverter();
                //byte[] data = (byte[])converter.ConvertTo(image, typeof(byte[]));
                using (var ms = new MemoryStream(image))
                {
                    Bitmap bmp = new Bitmap(Image.FromStream(ms));
                    OriginalImage = bmp;
                }

                SaveJpg(OriginalImage, filePath, 50);
            }
            catch (Exception ex)
            {

            }
        }

        // Save the file with a specific compression level.
        private void SaveJpg(Image image, string file_name, long compression)
        {
            try
            {
                EncoderParameters encoder_params = new EncoderParameters(1);
                encoder_params.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, compression);
                ImageCodecInfo image_codec_info = GetEncoderInfo("image/jpeg");
                System.IO.File.Delete(file_name);
                image.Save(file_name, image_codec_info, encoder_params);
            }
            catch (Exception ex)
            {

            }
        }

       private ImageCodecInfo GetEncoderInfo(string mime_type)
       {
           ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
           for (int i = 0; i <= encoders.Length; i++)
           {
               if (encoders[i].MimeType == mime_type) return encoders[i];
           }
           return null;
       }

         //Load a bitmap without locking it.
       private Bitmap LoadBitmapUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                return new Bitmap(bm);
            }
        }

    }
}
