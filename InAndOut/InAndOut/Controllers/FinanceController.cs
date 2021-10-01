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
    public class FinanceController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FinanceController(ApplicationDbContext db)
        {
            _db = db;
        }


        [AcceptVerbs("GET", "POST")]
        public ActionResult Index(string searchTxt, string SortOrder, string SortBy, int PageNumber = 1)
        {

            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;

            var model = _db.Finances.ToList();


            if (searchTxt != null)
            {
                model = _db.Finances.Where(x => x.ExpenseName.Contains(searchTxt)).ToList();
                //model = _db.Finances.Where(x => x.ExpenseName.Contains(searchTxt) || x.ExpenseType.Contains(searchTxt) || x.Amount.Contains(searchTxt)).ToList();
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

        public void ApplySorting(string SortOrder, string SortBy, List<Finance> model)
        {

            switch (SortBy)
            {
                case "Name":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    model = model.OrderBy(x => x.ExpenseName).ToList();
                                    break;
                                }

                            case "Desc":
                                {
                                    model = model.OrderByDescending(x => x.ExpenseName).ToList();
                                    break;
                                }

                            default:
                                {
                                    model = model.OrderBy(x => x.ExpenseName).ToList();
                                    break;
                                }
                        }

                        break;
                    }
                case "ExpenseType":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    model = model.OrderBy(x => x.ExpenseType).ToList();
                                    break;
                                }

                            case "Desc":
                                {
                                    model = model.OrderByDescending(x => x.ExpenseType).ToList();
                                    break;
                                }

                            default:
                                {
                                    model = model.OrderBy(x => x.ExpenseType).ToList();
                                    break;
                                }

                        }

                        break;
                    }

                default:
                    {
                        model = model.OrderBy(x => x.ExpenseName).ToList();
                        break;
                    }
            }

        }

        public List<Finance> ApplyPagination(List<Finance> model, int PageNumber)
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
        public IActionResult Create(Finance obj)
        {
            if (ModelState.IsValid)
            {
                _db.Finances.Add(obj);
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
            var obj = _db.Finances.Find(id);
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
            var obj = _db.Finances.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Finances.Remove(obj);
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
            var obj = _db.Finances.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Finance obj)
        {
            if (ModelState.IsValid)
            {
                _db.Finances.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
