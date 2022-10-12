using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using car4you.Model;
using car4you.Models;
using Microsoft.AspNetCore.Authorization;

namespace car4you.Controllers
{
    public class DenunciaController : Controller
    {
        private readonly storeContext _context;

        public DenunciaController(storeContext context)
        {
            _context = context;
        }

        // GET: Denuncia
        public async Task<IActionResult> Index()
        {
            
            await _context.AnuncioModel.FromSqlRaw("Select * from  ANUNCIO ").ToListAsync();
            await _context.EstadoModel.FromSqlRaw("Select * from  ESTADO_ANUNCIO ").ToListAsync();
            var denuncias = _context.DenunciaModel.FromSqlRaw("Select * from DENUNCIA").ToListAsync();
            return View(await _context.DenunciaModel.ToListAsync());
        }

        // GET: Denuncia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.DenunciaModel
                .FirstOrDefaultAsync(m => m.IDDENUNCIA == id);
            if (denuncia == null)
            {
                return NotFound();
            }

            return View(denuncia);
        }

        // GET: Denuncia/Create
        [Authorize]
        public IActionResult Create(int? id)
        { 
            ViewBag.idanuncio = id;
            return View();
        }

        // POST: Denuncia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id,string titulo,string descricao)
        {
            var datacriado= DateTime.Now.ToString("yyyy.MM.dd tt");
        _context.Database.ExecuteSqlRaw("Insert Into  DENUNCIA(id_anuncio,descricao,datad,relsovido,titulo,visto) Values({0},{1},{2},0,{3},0)",id,descricao,datacriado,titulo);
        return RedirectToAction("Index", "Home");
        }

        // GET: Denuncia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.DenunciaModel.FindAsync(id);
            if (denuncia == null)
            {
                return NotFound();
            }
            return View(denuncia);
        }

        // POST: Denuncia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDDENUNCIA,descricao,data,resolvido,titulo,visto,idanuncio")] Denuncia denuncia)
        {
            if (id != denuncia.IDDENUNCIA)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(denuncia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DenunciaExists(denuncia.IDDENUNCIA))
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
            return View(denuncia);
        }

        // GET: Denuncia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var denuncia = await _context.DenunciaModel
                .FirstOrDefaultAsync(m => m.IDDENUNCIA == id);
            if (denuncia == null)
            {
                return NotFound();
            }

            return View(denuncia);
        }

        // POST: Denuncia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var denuncia = await _context.DenunciaModel.FindAsync(id);
            _context.DenunciaModel.Remove(denuncia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DenunciaExists(int id)
        {
            return _context.DenunciaModel.Any(e => e.IDDENUNCIA == id);
        }
    }
}
