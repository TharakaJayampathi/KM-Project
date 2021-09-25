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
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index(string searchby, string search)
        {


            if (searchby == "Name")
            {
                IEnumerable<Employee> objList = _db.Employees;
                var model = _db.Employees.Where(x => x.Name == search || search == null).ToList();
                return View(model);
            }

            else
            {
                IEnumerable<Employee> objList = _db.Employees;
                var model = _db.Employees.Where(x => x.Designation == search || search == null).ToList();
                return View(model);
            }

            //IEnumerable<Employee> objList = _db.Employees;

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
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(obj);
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
            var obj = _db.Employees.Find(id);
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
            var obj = _db.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Employees.Remove(obj);
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
            var obj = _db.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

    }
}
