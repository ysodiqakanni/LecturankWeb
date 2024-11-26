using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LecturankWeb.Data;
using LecturankWeb.Models;

namespace LecturankWeb.Controllers
{
    public class SchoolController : Controller
    {
        private readonly LecturankDbContext _context;

        public SchoolController(LecturankDbContext context)
        {
            _context = context;
        }

        // GET: Schools
        public IActionResult Index()
        {
            return View(_context.Schools.Where(s => s.IsActive).ToList());
        }

        // GET: Schools/Details/5
        public IActionResult Details(int id)
        {
            var school = _context.Schools
                .Include(s => s.Lecturers)
                .FirstOrDefault(s => s.Id == id);
            return View(school);
        }

        // GET: Schools/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Schools/Create
        [HttpPost]
        public async Task<IActionResult> Create(School school)
        {
            if (ModelState.IsValid)
            {
                school.IsActive = true;
                _context.Schools.Add(school);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(school);
        }


        // GET: Schools/Edit/5
        public IActionResult Edit(int id)
        {
            var school = _context.Schools.Find(id);
            return View(school);
        }

        // POST: Schools/Edit/5
        [HttpPost]
        public IActionResult Edit(School school)
        {
            if (ModelState.IsValid)
            {
                _context.Schools.Update(school);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(school);
        }

        // GET: Schools/Delete/5
        public IActionResult Delete(int id)
        {
            var school = _context.Schools.Find(id);
            return View(school);
        }

        // POST: Schools/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var school = _context.Schools.Find(id);
            school.IsActive = false;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}