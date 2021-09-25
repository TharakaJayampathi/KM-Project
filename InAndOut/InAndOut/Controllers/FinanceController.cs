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


        public IActionResult Index(string searchby, string search)
        {
            if (searchby == "ExpenseName")
            {
                IEnumerable<Finance> objList = _db.Finances;
                var model = _db.Finances.Where(x => x.ExpenseName == search || search == null).ToList();
                return View(model);
            }

            else
            {
                IEnumerable<Finance> objList = _db.Finances;
                var model = _db.Finances.Where(x => x.ExpenseType == search || search == null).ToList();
                return View(model);
            }

            //IEnumerable<Finance> objList = _db.Finances;

            //return View(objList);

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
