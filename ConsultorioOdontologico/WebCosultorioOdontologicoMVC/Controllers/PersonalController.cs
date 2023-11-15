using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCosultorioOdontologicoMVC.Models;

namespace WebCosultorioOdontologicoMVC.Controllers
{
    public class PersonalController : Controller
    {
        private readonly LabConsultorioOdontologicoContext _context;

        public PersonalController(LabConsultorioOdontologicoContext context)
        {
            _context = context;
        }

        // GET: Personal
        public async Task<IActionResult> Index()
        {
              return _context.Personals != null ? 
                          View(await _context.Personals.ToListAsync()) :
                          Problem("Entity set 'LabConsultorioOdontologicoContext.Personals'  is null.");
        }

        // GET: Personal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Personals == null)
            {
                return NotFound();
            }

            var personal = await _context.Personals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personal == null)
            {
                return NotFound();
            }

            return View(personal);
        }

        // GET: Personal/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CedulaIdentidad,Nombres,PrimerApellido,SegundoApellido,Direccion,Celular,Cargo")] Personal personal)
        {
            if (!string.IsNullOrEmpty(personal.CedulaIdentidad))
            {
                personal.UsuarioRegistro = "sis457";
                personal.FechaRegistro = DateTime.Now;
                personal.Estado = 1;
                _context.Add(personal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personal);
        }

        // GET: Personal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Personals == null)
            {
                return NotFound();
            }

            var personal = await _context.Personals.FindAsync(id);
            if (personal == null)
            {
                return NotFound();
            }
            return View(personal);
        }

        // POST: Personal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CedulaIdentidad,Nombres,PrimerApellido,SegundoApellido,Direccion,Celular,Cargo,UsuarioRegistro,FechaRegistro,Estado")] Personal personal)
        {
            if (id != personal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonalExists(personal.Id))
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
            return View(personal);
        }

        // GET: Personal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Personals == null)
            {
                return NotFound();
            }

            var personal = await _context.Personals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personal == null)
            {
                return NotFound();
            }

            return View(personal);
        }

        // POST: Personal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Personals == null)
            {
                return Problem("Entity set 'LabConsultorioOdontologicoContext.Personals'  is null.");
            }
            var personal = await _context.Personals.FindAsync(id);
            if (personal != null)
            {
                _context.Personals.Remove(personal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonalExists(int id)
        {
          return (_context.Personals?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
