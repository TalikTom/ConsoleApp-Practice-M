using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Loto
    {

        public static string LotoString { get; set; }
        public static void GenerateLoto(int min, int max)
        {

            while (true)
            {

                List<int> list = new List<int>();
                Random rnd = new Random();
                int index = 0;

                while (true)
                {
                    int randomNum = rnd.Next(min, max);
                    list.Add(randomNum);
                    if (index == (min - 1))
                    {
                        break;
                    }
                    index++;
                }

                Console.WriteLine($"Your lucky {min} numbers are: ");

                foreach (int i in list)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine($"Do you want to generate new {min} lucky numbers (they won't be as lucky as the first set)? (Y/N)");



                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                {
                    break;
                }

                while (answer.ToLower() != "y" && answer.ToLower() != "n")
                {
                    Console.WriteLine("Invalid input! Please enter Y or N\n");
                    answer = Console.ReadLine();
                }

            }




        }

        public static string GenerateLotoString(int min, int max)
        {
            StringBuilder sb = new StringBuilder();

            List<int> list = new List<int>();
            Random rnd = new Random();
            int index = 0;

            while (true)
            {
                int randomNum = rnd.Next(min, max);
                list.Add(randomNum);
                if (index == (min - 1))
                {
                    break;
                }
                index++;
            }

            sb.AppendLine($"Your lucky {min} numbers are: ");

            foreach (int i in list)
            {
                sb.AppendLine(i.ToString());
            }
            LotoString = sb.ToString();

            return LotoString;

        }


        public static void simpleCreatePDF(string LotoString)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Console.WriteLine("Generating PDF...");

            // Create a new PDF document
            var document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            var page = document.AddPage();

            // Get an XGraphics object for drawing
            var gfx = XGraphics.FromPdfPage(page);

            // Create a font
            var font = new XFont("Arial", 12, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString(LotoString, font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);

            // Save the document...
            string fileName = $"C:\\Users\\student\\Documents\\Luka\\test2.pdf";
            document.Save(fileName);
            Console.WriteLine("PDF Generated!");
        }



    }
}
