using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace COMMON
{
    public class ImageUploader
    {
        /*
         *  0 => "dosya boş"
            1 => "zaten bu dosta kaydedilmiş"
            2 => "belirtilen uzantılara uymayan bir format"
            
         */
        public static string UploadImage(string serverPath, HttpPostedFileBase file)
        {
            var fileName = "";
            if (file != null)
            {
                var uniqueName = Guid.NewGuid();
                serverPath = serverPath.Replace("~", string.Empty);
                var fileArray = file.FileName.Split('.');
                string extension = fileArray[fileArray.Length - 1].ToLower();
                fileName = uniqueName + "." + extension;

                if (extension == "jpg" || extension == "png" || extension == "jpeg" || extension == "gif")
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath + fileName)))
                    {
                        return "1";
                    }
                    else
                    {
                        var filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                        file.SaveAs(filePath);
                    }
                }
                else
                {
                    return "2";
                }

            }
            else
            {
                return "0";
            }
            return fileName;
        }
    }
}

