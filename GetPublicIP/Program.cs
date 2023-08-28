using System.Net;

namespace GetPublicIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string result = wc.DownloadString("http://checkip.dyndns.org");
            string ip = result.Split(':')[1].Split('<')[0].Trim();

            Console.WriteLine(ip);
            Console.ReadKey();
        }
    }
}