using IronPdf;
using System;
using System.Threading.Tasks;

namespace IronPDFTestCaseApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Installation.DefaultRenderingEngine = IronPdf.Rendering.PdfRenderingEngine.Chrome;

            Console.WriteLine("Please insert file location of Pdf File:");
            var fileLocation = Console.ReadLine();
            var pdf = new PdfDocument(fileLocation);

            var ForegroundStamp = new IronPdf.Editing.HtmlStamp() { Html = "<h2 style='color:red'>Just some text", 
                Width = 50, Height = 50, Opacity = 50, 
                ZIndex = IronPdf.Editing.HtmlStamp.StampLayer.OnTopOfExistingPDFContent };
            await pdf.StampHTMLAsync(ForegroundStamp);

            Console.WriteLine("Please insert location to save Pdf file:");
            var saveLocation = Console.ReadLine();
            pdf.SaveAs(saveLocation);

            Console.WriteLine("File saved");
            Console.ReadLine();
        }
    }
}
