using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    [Authorize]
    public class ExamResultController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExamResultController(ApplicationDbContext db)
        {
            _db = db;
        }


        [AcceptVerbs("GET", "POST")]
        public ActionResult Index(string searchTxt, string SortOrder, string SortBy, int PageNumber = 1)
        {

            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;

            var model = _db.ExamResults.ToList();


            if (searchTxt != null)
            {
                model = _db.ExamResults.Where(x => x.StudentName.Contains(searchTxt)).ToList();
                //model = _db.ExamResults.Where(x => x.StudentName.Contains(searchTxt) || x.ExamName.Contains(searchTxt) || x.ExamType.Contains(searchTxt)).ToList();
                ApplySorting(SortOrder, SortBy, model);
                model = ApplyPagination(model, PageNumber);

            }

            else
            {

                ApplySorting(SortOrder, SortBy, model);
                model = ApplyPagination(model, PageNumber);

            }

            return View(model);
        }

        public void ApplySorting(string SortOrder, string SortBy, List<ExamResult> model)
        {

            switch (SortBy)
            {
                case "StudentName":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    model = model.OrderBy(x => x.StudentName).ToList();
                                    break;
                                }

                            case "Desc":
                                {
                                    model = model.OrderByDescending(x => x.StudentName).ToList();
                                    break;
                                }

                            default:
                                {
                                    model = model.OrderBy(x => x.StudentName).ToList();
                                    break;
                                }
                        }

                        break;
                    }
                case "ExamName":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    model = model.OrderBy(x => x.ExamName).ToList();
                                    break;
                                }

                            case "Desc":
                                {
                                    model = model.OrderByDescending(x => x.ExamName).ToList();
                                    break;
                                }

                            default:
                                {
                                    model = model.OrderBy(x => x.ExamName).ToList();
                                    break;
                                }

                        }

                        break;
                    }

                default:
                    {
                        model = model.OrderBy(x => x.ExamName).ToList();
                        break;
                    }
            }

        }

        public List<ExamResult> ApplyPagination(List<ExamResult> model, int PageNumber)
        {

            ViewBag.TotalPages = Math.Ceiling(model.Count() / 8.0);
            ViewBag.PageNumber = PageNumber;

            model = model.Skip((PageNumber - 1) * 8).Take(8).ToList();

            return model;
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExamResult obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExamResults.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExamResults.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ExamResults.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.ExamResults.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET Update
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExamResults.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExamResult obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExamResults.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
