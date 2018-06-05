using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.Download_file
{
    class Program
    {
        static void Main()
        {
            //https://telerikacademy.com/Content/Images/news-img01.png
            string remoteUri = "http://e-vraca.com/komputri/e-computers/ThinkcentreM58/l01.jpg";
            string fileName = "file.jpg";
            string webResource = null;
            WebClient myWeb = new WebClient();
            try
            {
                webResource = remoteUri;

                myWeb.DownloadFile(webResource, fileName);
                Console.WriteLine(Environment.CurrentDirectory);
                
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("File url is empty");
            }
            catch (WebException)
            {
                Console.WriteLine("File did not exitst on that address or an error occurred while download");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Already another file is in downloading process. After complete run program again.");
            }
            finally
            {
                //Some dispose
            }
        }
    }
}