using System;
using System.IO;
using Aspose.Pdf;

namespace PdfToWordConsole
{
    public class Converter
    {
        public Converter()
        {
            const string licenseFile = "Aspose.Total.lic";
            if (File.Exists(licenseFile))
            {
                Console.WriteLine("Setting License Files...");
                new License().SetLicense(licenseFile);
            }
            else
            {
                Console.WriteLine($"Cannot find {licenseFile}");
            }
        }
        public void ConvertPdfToWord(string fileName)
        {
            var dstFileName = Path.ChangeExtension(fileName, "docx");

            try
            {
                Document.Convert(fileName, null, dstFileName, new DocSaveOptions
                {
                    Format = DocSaveOptions.DocFormat.DocX,
                });

                Console.Out.WriteLine($"converted '{fileName}' to '{dstFileName}'");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
