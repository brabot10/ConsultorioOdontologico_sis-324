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
    public class MedicamentosController : Controller
    {
        private readonly LabConsultorioOdontologicoContext _context;

        public MedicamentosController(LabConsultorioOdontologicoContext context)
        {
            _context = context;
        }

        // GET: Medicamentos
        public async Task<IActionResult> Index()
        {
            var labConsultorioOdontologicoContext = _context.Medicamentos.Include(m => m.IdPacienteNavigation);
            return View(await labConsultorioOdontologicoContext.ToListAsync());
        }

        // GET: Medicamentos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Medicamentos == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamentos
                .Include(m => m.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicamento == null)
            {
                return NotFound();
            }

            return View(medicamento);
        }

        // GET: Medicamentos/Create
        public IActionResult Create()
        {
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id");
            return View();
        }

        // POST: Medicamentos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPaciente,Articulo,Descripcion,Precio,UsuarioRegistro,FechaRegistro,Estado")] Medicamento medicamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", medicamento.IdPaciente);
            return View(medicamento);
        }

        // GET: Medicamentos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Medicamentos == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamentos.FindAsync(id);
            if (medicamento == null)
            {
                return NotFound();
            }
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", medicamento.IdPaciente);
            return View(medicamento);
        }

        // POST: Medicamentos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPaciente,Articulo,Descripcion,Precio,UsuarioRegistro,FechaRegistro,Estado")] Medicamento medicamento)
        {
            if (id != medicamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicamentoExists(medicamento.Id))
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
            ViewData["IdPaciente"] = new SelectList(_context.Pacientes, "Id", "Id", medicamento.IdPaciente);
            return View(medicamento);
        }

        // GET: Medicamentos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Medicamentos == null)
            {
                return NotFound();
            }

            var medicamento = await _context.Medicamentos
                .Include(m => m.IdPacienteNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medicamento == null)
            {
                return NotFound();
            }

            return View(medicamento);
        }

        // POST: Medicamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Medicamentos == null)
            {
                return Problem("Entity set 'LabConsultorioOdontologicoContext.Medicamentos'  is null.");
            }
            var medicamento = await _context.Medicamentos.FindAsync(id);
            if (medicamento != null)
            {
                _context.Medicamentos.Remove(medicamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicamentoExists(int id)
        {
          return (_context.Medicamentos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
