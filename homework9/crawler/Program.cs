using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace crawler
{
    class Program
    {
   
    }
    public class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;

        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();

            string statrtUrl = "http://www.cnblogs.com/dstang2000/";
            //string statrtUrl = "http://www.baidu.com";
            if (args.Length >= 1) statrtUrl = args[0];
            //加入初始页面
            myCrawler.urls.Add(statrtUrl, false);
            //开始爬行
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了......");
            while (true)
            {
                const int MAX = 100;
                string[] current = new string[MAX];
                int index = 0;


                //找到一个还没有下载过的链接
                foreach (string url in urls.Keys)
                {
                    //已经下载过的，不再下载
                    if ((bool)urls[url]) continue;
                    current[index] = url;
                    index++;
                    if (index >= 10) break;
                }
                if (current == null || count > 10) break;

                //下载
                Parallel.For(0, index, i =>
                {
                    Console.WriteLine("爬行" + current[i] + "页面!");
                    string html = DownLoad(current[i]);

                    //count++;
                    urls[current[i]] = true;
                    //解析，并加入新的链接
                    Parse(html);
                });
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                count++;
                return html;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        
        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection mathces = new Regex(strRef).Matches(html);
            foreach (Match match in mathces)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ', '>');
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;

            }

        }
    }
}
