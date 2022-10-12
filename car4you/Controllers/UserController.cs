using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using car4you.Model;
using car4you.Models;

namespace car4you.Controllers
{
    public class UserController : Controller
    {
        private readonly storeContext _context;

        public UserController(storeContext context)
        {
            _context = context;
        }

        // GET: User
        public async Task<IActionResult> Index()
        {
           // return View(await _context.UserModel.ToListAsync());
       //  return Redirect();
       await _context.UserModel.ToListAsync();
      // await _context.AnuncioModel.ToListAsync();
       return RedirectToAction( "Login","Home");
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizador = await _context.UserModel
                .FirstOrDefaultAsync(m => m.IDUTILIZADOR == id);
            if (utilizador == null)
            {
                return NotFound();
            }

            return View(utilizador);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nome,distrito,cidade,morada,portaAndar,codPostal,nif,telemovel,tipoutilizador,email,passe")] Utilizador utilizador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utilizador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(utilizador);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizador = await _context.UserModel.FindAsync(id);
            if (utilizador == null)
            {
                return NotFound();
            }
            return View(utilizador);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDUTILIZADOR,nome,distrito,cidade,morada,portaAndar,codPostal,nif,telemovel,tipoutilizador,email,passe")] Utilizador utilizador)
        {
            if (id != utilizador.IDUTILIZADOR)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilizador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilizadorExists(utilizador.IDUTILIZADOR))
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
            return View(utilizador);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizador = await _context.UserModel
                .FirstOrDefaultAsync(m => m.IDUTILIZADOR == id);
            if (utilizador == null)
            {
                return NotFound();
            }

            return View(utilizador);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utilizador = await _context.UserModel.FindAsync(id);
            _context.UserModel.Remove(utilizador);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilizadorExists(int id)
        {
            return _context.UserModel.Any(e => e.IDUTILIZADOR == id);
        }
    }
}
