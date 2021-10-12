using IronPdf;
using System;

namespace IronPDFTestCaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Installation.DefaultRenderingEngine = IronPdf.Rendering.PdfRenderingEngine.Chrome;

            Console.WriteLine("Please insert file location of Pdf File:");
            var fileLocation = Console.ReadLine();
            var pdf = new PdfDocument(fileLocation);

            var ForegroundStamp = new IronPdf.Editing.HtmlStamp() { Html = "<h2 style='color:red'>Just some text", 
                Width = 50, Height = 50, Opacity = 50, 
                ZIndex = IronPdf.Editing.HtmlStamp.StampLayer.OnTopOfExistingPDFContent };
            pdf.StampHTMLAsync(ForegroundStamp);

            Console.WriteLine("Please insert location to save Pdf file:");
            var saveLocation = Console.ReadLine();
            pdf.SaveAs(saveLocation);

            Console.WriteLine("File saved");
            Console.ReadLine();
        }
    }
}
