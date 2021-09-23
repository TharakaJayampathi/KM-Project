using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ILogger<InvoiceController> _logger;

        public InvoiceController(ILogger<InvoiceController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult ViewDocument()
        //{
        //    string fileName = Request.Form["fileToView"];
        //    string outputDirectory = ("Output/");
        //    string outputFilePath = Path.Combine(outputDirectory, "output.pdf");
        //    using (Viewer viewer = new ("SourceDocument/" + fileName))
        //    {
        //            PdfViewOptions options = new PdfViewOptions(outputFilePath);
        //            viewer.View(options);   
        //    }

        //    var fileStream = new FileStream("Output/" + "output.pdf",
        //        FileMode.Open,
        //        FileAccess.Read
        //        );
        //    var fsResult = new FileStreamResult(fileStream, "application/pdf");
        //    return fsResult;
        //}








        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
