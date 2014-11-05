using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
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
            GPLvar = new System.Net.WebClient().DownloadString("http://www.gnu.org/licenses/gpl-3.0.txt");
            Console.WriteLine("Gnu GPL:\n");
            Console.WriteLine(GPLvar);
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
