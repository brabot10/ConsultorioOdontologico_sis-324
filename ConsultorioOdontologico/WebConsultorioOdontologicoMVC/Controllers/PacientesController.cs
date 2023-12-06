using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebConsultorioOdontologicoMVC.Models;

namespace WebConsultorioOdontologicoMVC.Controllers
{
    public class PacientesController : Controller
    {
        private readonly LabSis324Context _context;
        bool esNuevo = false;

        public PacientesController(LabSis324Context context)
        {
            _context = context;
        }

        // GET: Pacientes
        public async Task<IActionResult> Index()
        {
            var labSis324Context = _context.Pacientes.Include(p => p.IdPersonalNavigation);
            return View(await labSis324Context.Where(x => x.Estado != -1).ToListAsync());
        }

        // GET: Pacientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .Include(p => p.IdPersonalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // GET: Pacientes/Create
        public IActionResult Create()
        {
            ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Nombres");
            esNuevo = true;
            return View();
        }

        // POST: Pacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdPersonal,Nombres,CedulaIdentidad,Alergias,FechaNacimiento,Celular")] Paciente paciente)
        {
            var personalFiltrados = _context.Personals.Where(x => x.Estado != -1).ToList();
            if (!string.IsNullOrEmpty(paciente.Nombres))
            {
                if (!Regex.IsMatch(paciente.Nombres, "^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ()\\s]+$"))
                {
                    ModelState.AddModelError(nameof(paciente.Nombres), "El campo Nombres solo puede contener letras");
                }
                paciente.UsuarioRegistro = User.Identity?.Name;
                paciente.FechaRegistro = DateTime.Now;
                paciente.Estado = 1;
                _context.Add(paciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["IdPersonal"] = new SelectList(personalFiltrados, "Id", "Nombres", paciente.IdPersonal);  
            return View(paciente);
        }

        // GET: Pacientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }
            ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Nombres", paciente.IdPersonal);
            return View(paciente);
        }

        // POST: Pacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdPersonal,Nombres,CedulaIdentidad,Alergias,FechaNacimiento,Celular")] Paciente paciente)
        {
            if (id != paciente.Id)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(paciente.Nombres))
            {
                try
                {
                    paciente.UsuarioRegistro = "sis324 web";
                    paciente.FechaRegistro = DateTime.Now;
                    paciente.Estado = 1;
                    _context.Update(paciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PacienteExists(paciente.Id))
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
            ViewData["IdPersonal"] = new SelectList(_context.Personals, "Id", "Id", paciente.IdPersonal);
            return View(paciente);
        }

        // GET: Pacientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pacientes == null)
            {
                return NotFound();
            }

            var paciente = await _context.Pacientes
                .Include(p => p.IdPersonalNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (paciente == null)
            {
                return NotFound();
            }

            return View(paciente);
        }

        // POST: Pacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pacientes == null)
            {
                return Problem("Entity set 'LabSis324Context.Pacientes'  is null.");
            }
            var paciente = await _context.Pacientes.FindAsync(id);
            if (paciente != null)
            {
                paciente.Estado = -1;
               // _context.Pacientes.Remove(paciente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PacienteExists(int id)
        {
          return (_context.Pacientes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
