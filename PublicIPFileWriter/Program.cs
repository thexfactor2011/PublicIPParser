using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;

namespace PublicIPFileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://whatismyip.org/";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fileName = path + @"\Dropbox\personal\PublicIP.txt";

            var web = new HtmlWeb();
            var document = web.Load(url);
            var page = document.DocumentNode;

            foreach (var item in page.QuerySelectorAll("span"))
            {
                using (StreamWriter stream = new StreamWriter (fileName))
                {
                    stream.WriteLine(item.InnerText);
                }
                break;
            }            
        }        
    }
}
