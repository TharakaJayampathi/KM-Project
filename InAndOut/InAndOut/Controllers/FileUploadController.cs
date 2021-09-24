using InAndOut.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InAndOut.Models;
using Microsoft.AspNetCore.Authorization;

namespace InAndOut.Controllers
{
    [Authorize]
    public class FileUploadController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _iweb;

        public FileUploadController(ApplicationDbContext db, IWebHostEnvironment iweb)
        {
            _db = db;
            _iweb = iweb;
        }

        public IActionResult Index()
        {
            var displayfiles = _db.Savemedia.ToList();
            return View(displayfiles);
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile fileobj, FileUpload fileUpload)
        {
            var fileext = Path.GetExtension(fileobj.FileName);
            if (fileext == ".jpg" || fileext == ".jpeg" || fileext == ".gif" || fileext == ".docx" || fileext == ".pptx"
                || fileext == ".xlsx" || fileext == ".csv" || fileext == ".pdf" || fileext == ".mp4")
            {
                var uploadfile = Path.Combine(_iweb.WebRootPath, "Files", fileobj.FileName);
                var stream = new FileStream(uploadfile, FileMode.Create);
                await fileobj.CopyToAsync(stream);
                stream.Close();

                fileUpload.Imgname = fileobj.FileName;
                fileUpload.Imgpath = uploadfile;
                await _db.Savemedia.AddAsync(fileUpload);
                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var displayfiledetails = await _db.Savemedia.FindAsync(id);
            return View(displayfiledetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(IFormFile fileobj, FileUpload fileUpload, string fname, int id)
        {
            if (ModelState.IsValid)
            {
                var getfiledetails = await _db.Savemedia.FindAsync(id);
                _db.Savemedia.Remove(getfiledetails);
                fname = Path.Combine(_iweb.WebRootPath, "Files", getfiledetails.Imgname);
                FileInfo fi = new FileInfo(fname);
                if (fi.Exists)
                {
                    System.IO.File.Delete(fname);
                    fi.Delete();
                }


                var fileext = Path.GetExtension(fileobj.FileName);
                if (fileext == ".jpg" || fileext == ".jpeg" || fileext == ".gif" || fileext == ".docx" || fileext == ".pptx"
                || fileext == ".xlsx" || fileext == ".csv" || fileext == ".pdf" || fileext == ".mp4")
                {
                    var uploadfile = Path.Combine(_iweb.WebRootPath, "Files", fileobj.FileName);
                    var stream = new FileStream(uploadfile, FileMode.Create);
                    await fileobj.CopyToAsync(stream);
                    stream.Close();

                    fileUpload.Imgname = fileobj.FileName;
                    fileUpload.Imgpath = uploadfile;
                    _db.Update(fileUpload);
                    await _db.SaveChangesAsync();
                }
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var displayfiledetails = await _db.Savemedia.FindAsync(id);
            return View(displayfiledetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var displayfiledetails = await _db.Savemedia.FindAsync(id);
            return View(displayfiledetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string fname, int id)
        {
            var getfiledetails = await _db.Savemedia.FindAsync(id);
            _db.Savemedia.Remove(getfiledetails);
            fname = Path.Combine(_iweb.WebRootPath, "Files", getfiledetails.Imgname);
            FileInfo fi = new FileInfo(fname);
            if (fi.Exists)
            {
                System.IO.File.Delete(fname);
                fi.Delete();
            }

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}
