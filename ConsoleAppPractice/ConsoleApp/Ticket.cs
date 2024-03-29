﻿using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp
{
    public static class Ticket
    {
        
        public static void LotoGrid(int min, int max, int breakPoint)
        {


            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= min; i++)
            {
                for (int j = 1; j <= max; j++)
                {
                    sb.Append($"{i * j}\t");
                    if (j % breakPoint == 0)
                    {
                        sb.AppendLine();
                    }
                }
                sb.AppendLine();
            }

            string result = sb.ToString();

           
            Logger("Loto 6 od 49 ticket", result);
            Console.WriteLine("Your ticket has been saved to .txt file, press enter to continue");
            Console.ReadLine();

            
        }



        public static void WriteLotoToTxt(int min, int max)
        {
            string lotoString = Loto.GenerateLotoString(min, max);

            Logger("Your lucky number", lotoString);
                        
        }

        


        public static void Logger(string title, string value)
        {
            string fileName = $"C:\\Users\\student\\Documents\\Luka\\consoleapp.txt";

            using FileStream fs = File.Create(fileName);
            using StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine(title);
            sr.WriteLine(value);

            Console.WriteLine(value);
        }

    }
}
