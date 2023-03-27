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
        public static string GenerateLoto(int min, int max)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            while (true)
            {
                sb.AppendLine($"Your lucky {min} numbers are: ");

                List<int> list = new List<int>();
                for (int i = 0; i < min; i++)
                {
                    int randomNum;
                    do
                    {
                        randomNum = rnd.Next(min, max);
                    } while (list.Contains(randomNum));
                    list.Add(randomNum);
                }

                foreach (int num in list)
                {
                    sb.AppendLine(num.ToString());
                    Console.WriteLine(num);
                }

                Console.WriteLine($"Do you want to generate new {min} lucky numbers? (Y/N)");
                string answer = Console.ReadLine();

                while (answer.ToLower() != "y" && answer.ToLower() != "n")
                {
                    Console.WriteLine("Invalid input! Please enter Y or N\n");
                    answer = Console.ReadLine();
                }

                if (answer.ToLower() == "n")
                {
                    break;
                }
            }
           

            LotoString = sb.ToString();

            return LotoString;
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


        public static void SimpleCreatePDF(string LotoString)
        {
            string fileName = @"C:\Users\student\Documents\Luka\LuckyNumbers.pdf";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            Console.WriteLine("Generating PDF...");

            Console.WriteLine("Your PDF document has been succesfully saved");
            
            Console.WriteLine("PDF file has been saved to: " + fileName);
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("In order to remove [][] in the generated PDF file please consider Premium Console App");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            // Create a new PDF document
            var document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page with margins
            var page = document.AddPage();
            var margin = 20; // Set the margin size
            var gfx = XGraphics.FromPdfPage(page);
            var width = page.Width.Point - margin * 2;
            var height = page.Height.Point - margin * 2;


            // Create a font
            var font = new XFont("Arial", 12, XFontStyle.BoldItalic);

            // Draw the text with margins
            var format = new XStringFormat();
            format.Alignment = XStringAlignment.Near;
            format.LineAlignment = XLineAlignment.Near;
            var rect = new XRect(margin, margin, width, height);
            gfx.DrawString(LotoString, font, XBrushes.Black, rect, format);

            // Save the document
            
            document.Save(fileName);

            




        }



    }
}
