// See https://aka.ms/new-console-template for more information
using System;
using ConvertApiDotNet;
using PptxtoPdf;
namespace ConvertApiDotNetTest
{
    class Program
    {
         static async Task Main(string[] args)
        {
            
            //Get your secret at https://www.convertapi.com/a
            var convertApi = new ConvertApi("Your ConvertAPI secret");
            MonitoringScript monitoringScript = new MonitoringScript(@"Your input directory");
            //Set input and output formats and pass file parameter. 
            //PPTX to PDF API. Read more https://www.convertapi.com/pptx-to-pdf
            var convertToPdf = await  convertApi.ConvertAsync("pptx", "pdf", new ConvertApiFileParam(@Path.GetFullPath(monitoringScript.CatchPptxFiles())));
            //Save PDF file 
            var files = await  convertToPdf.SaveFilesAsync(@"Your output directory");
            //monitoringScript.CatchPptxFiles(),@Path.GetFullPath(monitoringScript.CatchPptxFiles())
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
    }    
}   