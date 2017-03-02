using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace baykus_edr_client
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == "kur")
            {
                Console.Write("Kuruluyor: ");
                Console.WriteLine(args[1]);
                ajaniKur();
            }
        

        }

        private static void ajaniKur()
        {
            Process.Start("calc.exe");
        }
    }
}
