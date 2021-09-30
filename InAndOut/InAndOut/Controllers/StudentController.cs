﻿using InAndOut.Data;
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
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentController(ApplicationDbContext db)
        {
            _db = db;
        }


        [AcceptVerbs("GET", "POST")]
        public ActionResult Index(string searchTxt, string SortOrder, string SortBy, int PageNumber = 1)
        {

            ViewBag.SortOrder = SortOrder;
            ViewBag.SortBy = SortBy;

            var model = _db.Students.ToList();


            if (searchTxt != null)
            {
                model = _db.Students.Where(x => x.Name.Contains(searchTxt) || x.Gender.Contains(searchTxt) || x.Address.Contains(searchTxt)).ToList();
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

        public void ApplySorting(string SortOrder, string SortBy, List<Student> model)
        {

            switch (SortBy)
            {
                case "Name":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    model = model.OrderBy(x => x.Name).ToList();
                                    break;
                                }

                            case "Desc":
                                {
                                    model = model.OrderByDescending(x => x.Name).ToList();
                                    break;
                                }

                            default:
                                {
                                    model = model.OrderBy(x => x.Name).ToList();
                                    break;
                                }
                        }

                        break;
                    }
                case "Section":
                    {
                        switch (SortOrder)
                        {
                            case "Asc":
                                {
                                    model = model.OrderBy(x => x.Section).ToList();
                                    break;
                                }

                            case "Desc":
                                {
                                    model = model.OrderByDescending(x => x.Section).ToList();
                                    break;
                                }

                            default:
                                {
                                    model = model.OrderBy(x => x.Section).ToList();
                                    break;
                                }

                        }

                        break;
                    }

                default:
                    {
                        model = model.OrderBy(x => x.Name).ToList();
                        break;
                    }
            }

        }

        public List<Student> ApplyPagination(List<Student> model, int PageNumber)
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
        public IActionResult Create(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
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
            var obj = _db.Students.Find(id);
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
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Students.Remove(obj);
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
            var obj = _db.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Student obj)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
