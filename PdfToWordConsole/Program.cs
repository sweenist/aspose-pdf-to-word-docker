using System;
using System.Collections.Generic;

namespace PdfToWordConsole
{
    public class Program
    {

        static void Main()
        {
            var fileResources = new Dictionary<char, string>
            {
                {'1', @".\Files\FileThatFailsIn1909.pdf" },
                {'2', @".\Files\ThisFileIsOkay.pdf" },
            };
            var converter = new Converter();
            while (true)
            {

                Console.WriteLine("Please select which file to process:");
                Console.WriteLine("1 - FileThatFailsIn1909.pdf - this is the file that fails PDF to WOrd conversion");
                Console.WriteLine("2 - ThisFileIsOkay.pdf - this file will convert. It was saved as Microsoft PDF");
                Console.WriteLine("'x' will exit program.");
                Console.WriteLine();

                var key = Console.ReadKey();
                Console.WriteLine();

                if (key.KeyChar.Equals('1') || key.KeyChar.Equals('2'))
                {
                    Console.WriteLine("Converting File");
                    try {
                        converter.ConvertPdfToWord(fileResources[key.KeyChar]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Conversion failed...");
                        Console.WriteLine(e.Message);
                        Console.WriteLine();
                        Console.WriteLine(e.StackTrace);
                    }
                    
                }
                if (key.KeyChar.Equals('x'))
                {
                    return;
                }
            }
        }
    }
}
