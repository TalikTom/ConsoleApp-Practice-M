using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Ticket
    {




        public static void WriteLotoToTxt(int min, int max)
        {
            string lotoString = Loto.GenerateLotoString(min, max);

            string fileName = $"C:\\Users\\student\\Documents\\Luka\\consoleapp.txt";

            using FileStream fs = File.Create(fileName);
            using StreamWriter sr = new StreamWriter(fs);


            sr.WriteLine(lotoString);

            Console.WriteLine(lotoString);
        }

    }
}
