using GroupDocs.Viewer;
using GroupDocs.Viewer.Options;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    [Authorize]
    public class DocumentViewController : Controller
    {
        private readonly ILogger<DocumentViewController> _logger;

        public DocumentViewController(ILogger<DocumentViewController> logger)
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

        [HttpPost]
        public IActionResult ViewDocument()
        {
            string fileName = Request.Form["fileToView"];
            string outputDirectory = ("Output/");
            string outputFilePath = Path.Combine(outputDirectory, "output.pdf");
            using (Viewer viewer = new("SourceDocument/" + fileName))
            {
                PdfViewOptions options = new PdfViewOptions(outputFilePath);
                viewer.View(options);
            }

            var fileStream = new FileStream("Output/" + "output.pdf",
                FileMode.Open,
                FileAccess.Read
                );
            var fsResult = new FileStreamResult(fileStream, "application/pdf");
            return fsResult;
        }
    }
}
