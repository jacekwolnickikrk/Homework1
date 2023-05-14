using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A1Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient myWebClient = new WebClient();

            string url = "https://www.google.com/logos/doodles/2022/manfredo-fests-86th-birthday-6753651837109784-2x.png";

            string resultPath = "c:\\data\\image.png";
            myWebClient.DownloadFile(url, resultPath);


        }
    }
}