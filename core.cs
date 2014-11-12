using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenInstaller
{
    class core
    {
        public static string GPLvar;

        static void Main(string[] args)
        {
            Console.WriteLine("OpenInstaller InDev");
            Console.WriteLine("by Alexmitter");
            Console.Read();
            Rutine();
        }

        public static void GPL()
        {
            if (!File.Exists("LICENSE.txt"))
            {
                using (var file = new StreamWriter("LICENSE.txt", false))
                {
#warning this is bad code, should be using HttpWebResponse
                    file.Write(new WebClient().DownloadString("http://www.gnu.org/licenses/gpl-3.0.txt"));
                }
            }

            Console.WriteLine("Gnu GPL:\n");
            Console.WriteLine(new StreamReader("LICENSE.txt").ReadToEnd());
            Console.Read();
        }

        public static void Rutine()
        {
            GPL();

        }

        public static void Unpack()
        {
            
        }

        





    }
}
