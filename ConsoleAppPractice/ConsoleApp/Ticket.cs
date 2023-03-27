using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Ticket
    {

        public static void StreamWriterWrite()
        {
            string lotoString = Loto.GenerateLotoString(6, 49);

            string fileName = $"C:\\Users\\student\\Documents\\Luka\\consoleapp.txt";

            using FileStream fs = File.Create(fileName);
            using StreamWriter sr = new StreamWriter(fs);


            sr.WriteLine(lotoString);

            Console.WriteLine(lotoString);
        }

    }
}
