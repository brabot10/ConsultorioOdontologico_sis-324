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
    public class CitasController : Controller
    {
        private readonly LabConsultorioOdontologicoContext _context;

        public CitasController(LabConsultorioOdontologicoContext context)
        {
            _context = context;
        }

        // GET: Citas
        public async Task<IActionResult> Index()
        {
            var labConsultorioOdontologicoContext = _context.Cita.Include(c => c.IdPacienteNavigation);
            return View(await labConsultorioOdontologicoContext.ToListAsync());
        }

        // GET: Citas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cita == null)
            {
                return NotFound();
            }

            var citum = await _context.Cita
                .Include(c => c.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (citum == null)
            {
                return NotFound();
            }

            return View(citum);
        }

        // GET: Citas/Create
        public IActionResult Create()
        {
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id");
            return View();
        }

        // POST: Citas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPaciente,Fecha,Hora,Tratamiento,Pago,ACuenta,UsuarioRegistro,FechaRegistro,Estado")] Citum citum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(citum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", citum.IdPaciente);
            return View(citum);
        }

        // GET: Citas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cita == null)
            {
                return NotFound();
            }

            var citum = await _context.Cita.FindAsync(id);
            if (citum == null)
            {
                return NotFound();
            }
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", citum.IdPaciente);
            return View(citum);
        }

        // POST: Citas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPaciente,Fecha,Hora,Tratamiento,Pago,ACuenta,UsuarioRegistro,FechaRegistro,Estado")] Citum citum)
        {
            if (id != citum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(citum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CitumExists(citum.Id))
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
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", citum.IdPaciente);
            return View(citum);
        }

        // GET: Citas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cita == null)
            {
                return NotFound();
            }

            var citum = await _context.Cita
                .Include(c => c.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (citum == null)
            {
                return NotFound();
            }

            return View(citum);
        }

        // POST: Citas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cita == null)
            {
                return Problem("Entity set 'LabConsultorioOdontologicoContext.Cita'  is null.");
            }
            var citum = await _context.Cita.FindAsync(id);
            if (citum != null)
            {
                _context.Cita.Remove(citum);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CitumExists(int id)
        {
          return (_context.Cita?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
