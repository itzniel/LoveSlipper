using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoveSlipper.Data;
using LoveSlipper.Models;

namespace LoveSlipper.Controllers
{
    public class SlippersController : Controller
    {
        private readonly LoveSlipperContext _context;

        public SlippersController(LoveSlipperContext context)
        {
            _context = context;
        }

        // GET: Slippers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movie.ToListAsync());
        }

        // GET: Slippers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slipper == null)
            {
                return NotFound();
            }

            return View(slipper);
        }

        // GET: Slippers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slippers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,ReleaseDate,Material,Color,Category,Price,Rating")] Slipper slipper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slipper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slipper);
        }

        // GET: Slippers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Movie.FindAsync(id);
            if (slipper == null)
            {
                return NotFound();
            }
            return View(slipper);
        }

        // POST: Slippers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,ReleaseDate,Material,Color,Category,Price,Rating")] Slipper slipper)
        {
            if (id != slipper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slipper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlipperExists(slipper.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(slipper);
        }

        // GET: Slippers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipper = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slipper == null)
            {
                return NotFound();
            }

            return View(slipper);
        }

        // POST: Slippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slipper = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(slipper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlipperExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
