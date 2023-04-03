using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaoCaoBaiTapLonNhom02.Models;

namespace BaoCaoBaiTapLonNhom02.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SinhVienController(ApplicationDbContext context)
        {
            _context = context;
        }

         //GET: SinhVien
        public async Task<IActionResult> Index()
        {
           var applicationDbContext = _context.SinhVien.Include(s => s.Nhom).Include(s => s.Cathi);
          return View(await applicationDbContext.ToListAsync());
        }
         //GET: SinhVien/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.SinhVien == null)
            {
                return NotFound();
            }

            var sinhVien = await _context.SinhVien
                .Include(s => s.Nhom)
                .FirstOrDefaultAsync(m => m.MaSV == id);
            if (sinhVien == null)
            {
                return NotFound();
            }

            return View(sinhVien);
        }

        // GET: SinhVien/Create
        public IActionResult Create()
        {
            ViewData["MaNhom"] = new SelectList(_context.Set<Nhom>(), "MaNhom", "MaNhom");
            ViewData["MaCathi"] = new SelectList(_context.Set<Cathi>(), "MaCathi", "MaCathi");
            return View();
        }

        // POST: SinhVien/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaSV,TenSV,MaNhom,MaCathi")] SinhVien sinhVien)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sinhVien);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaNhom"] = new SelectList(_context.Set<Nhom>(), "MaNhom", "MaNhom", sinhVien.MaNhom);
            ViewData["MaCathi"] = new SelectList(_context.Set<Cathi>(), "MaCathi", "MaCathi", sinhVien.MaCathi);
            return View(sinhVien);
        }

        // GET: SinhVien/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.SinhVien == null)
            {
                return NotFound();
            }

            var sinhVien = await _context.SinhVien.FindAsync(id);
            if (sinhVien == null)
            {
                return NotFound();
            }
            ViewData["MaNhom"] = new SelectList(_context.Set<Nhom>(), "MaNhom", "MaNhom", sinhVien.MaNhom);
            ViewData["MaCathi"] = new SelectList(_context.Set<Cathi>(), "MaCathi", "MaCathi", sinhVien.MaCathi);
            return View(sinhVien);
        }

        // POST: SinhVien/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaSV,TenSV,MaNhom")] SinhVien sinhVien)
        {
            if (id != sinhVien.MaSV)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sinhVien);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SinhVienExists(sinhVien.MaSV))
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
            ViewData["MaNhom"] = new SelectList(_context.Set<Nhom>(), "MaNhom", "MaNhom", sinhVien.MaNhom);
            ViewData["MaCathi"] = new SelectList(_context.Set<Cathi>(), "MaCathi", "MaCathi", sinhVien.MaCathi);
            return View(sinhVien);
        }

        // GET: SinhVien/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.SinhVien == null)
            {
                return NotFound();
            }

            var sinhVien = await _context.SinhVien
                .Include(s => s.Nhom)
                .FirstOrDefaultAsync(m => m.MaSV == id);
            if (sinhVien == null)
            {
                return NotFound();
            }

            return View(sinhVien);
        }

        // POST: SinhVien/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.SinhVien == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SinhVien'  is null.");
            }
            var sinhVien = await _context.SinhVien.FindAsync(id);
            if (sinhVien != null)
            {
                _context.SinhVien.Remove(sinhVien);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SinhVienExists(string id)
        {
          return (_context.SinhVien?.Any(e => e.MaSV == id)).GetValueOrDefault();
        }
    }
}
