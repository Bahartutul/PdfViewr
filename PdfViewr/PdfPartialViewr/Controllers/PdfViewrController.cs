using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PdfPartialViewr.Controllers
{
    public class PdfViewrController : Controller
    {
        //
        // GET: /PdfViewr/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyPdfResultIndex()
        {

            return View();
        }

        public ActionResult MyPdfResult()
        {
            //string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"500px\" height=\"300px\">";
            //embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            //embed += "</object>";
            //TempData["Embed"] = string.Format(embed, VirtualPathUtility.ToAbsolute("G:/DigitalArchivingWithNoteSheet/Image1/Economic Census 2013 District Report Bagerhat.pdf"));

            //return PartialView("_Viewpdf", TempData["Embed"]);
           // Response.ContentType = "application/pdf";
           // Response.AddHeader("Content-Disposition", @"filename=""IT Report.pdf""");
           //Response.TransmitFile(@"G:\DigitalArchivingWithNoteSheet\Image1\Economic Census 2013 District Report Bagerhat.pdf");

           //PdfReader fileName =new PdfReader( @"G:\DigitalArchivingWithNoteSheet\Image1\Economic Census 2013 District Report Bagerhat.pdf");
           //string contentType = "application/pdf";
           //TempData["Embed"] = fileName;

            //StringBuilder text = new StringBuilder();
            //string filepath=@"G:\DigitalArchivingWithNoteSheet\Image1\Economic Census 2013 District Report Bagerhat.pdf";
            //using (PdfReader reader = new PdfReader(@"G:\DigitalArchivingWithNoteSheet\Image1\Economic Census 2013 District Report Bagerhat.pdf"))
            //{
            //    for (int i = 1; i <= reader.NumberOfPages; i++)
            //    {
            //        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            //    }
            //}
            //TempData["Embed"] = text;

            string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"500px\" height=\"300px\">";
            embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            embed += "</object>";
            TempData["Embed"] = string.Format(embed, VirtualPathUtility.ToAbsolute("~/na samni val  Census 2013 District Report Bagerhat.pdf"));

            return PartialView("_Viewpdf", TempData["Embed"]);
           
        }
	}
}