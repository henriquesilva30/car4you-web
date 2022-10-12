using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using car4you.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using car4you.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace car4you.Controllers
{
    public class HomeController : Controller
    {
        private readonly storeContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,storeContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        { 
            await _context.CombustivelModel.FromSqlRaw("Select * from  COMBUSTIVEL ").ToListAsync();
            await _context.EstadoModel.FromSqlRaw("Select * from  ESTADO_ANUNCIO ").ToListAsync();
            await _context.DesgasteModel.FromSqlRaw("Select * from TIPO_DESGASTE").ToListAsync();
            await _context.ModeloModel.FromSqlRaw("Select * from  MODELO ").ToListAsync();
            await _context.SegmentoModel.FromSqlRaw("Select * from  TIPO_SEGMENTO ").ToListAsync();
            await _context.TipoVeiculoModel.FromSqlRaw("Select * from  TIPO_VEICULO ").ToListAsync();
            await _context.UtilizadorModel.FromSqlRaw("Select * from  UTILIZADOR ").ToListAsync();
            //   var anuncios = _context.AnuncioController.FromSqlRaw("Select a.*,c.ID_COMBUSTIVEL as idcom, c.DESIGNACAO as cdes from ANUNCIO a, COMBUSTIVEL c where c.ID_COMBUSTIVEL = a.ID_COMBUSTIVEL").ToListAsync();
            var anuncios = _context.AnuncioModel.FromSqlRaw("Select * from ANUNCIO where ID_ESTADO = 1").ToListAsync();
            //     var anuncios = _context.AnuncioControllerVer.FromSqlRaw("Select a.*,c.ID_COMBUSTIVEL as idcom, c.DESIGNACAO as cdes from ANUNCIO a, COMBUSTIVEL c where c.ID_COMBUSTIVEL = a.ID_COMBUSTIVEL").ToListAsync();
            //   var anuncios = _context.AnuncioController.FromSqlRaw("Select a.ID_ANUNCIO as id,a.DESIGNACAO,COMBUSTIVEL.DESIGNACAO  from ANUNCIO a, COMBUSTIVEL INNER JOIN COMBUSTIVEL on a.ID_COMBUSTIVEL = COMBUSTIVEL.ID_COMBUSTIVEL").ToListAsync();
         
          
            return View(await anuncios);
        }

        public IActionResult Privacy()
        {
            return View();
        } 
        [HttpGet("denied")]
        public IActionResult Denied()
        {
            return View();
        } 
        public async Task<IActionResult> Details(int? id)
        {
            await _context.CombustivelModel.FromSqlRaw("Select * from  COMBUSTIVEL ").ToListAsync();
            await _context.EstadoModel.FromSqlRaw("Select * from  ESTADO_ANUNCIO ").ToListAsync();
            await _context.DesgasteModel.FromSqlRaw("Select * from TIPO_DESGASTE").ToListAsync();
            await _context.ModeloModel.FromSqlRaw("Select * from  MODELO ").ToListAsync();
            await _context.SegmentoModel.FromSqlRaw("Select * from  TIPO_SEGMENTO ").ToListAsync();
            await _context.TipoVeiculoModel.FromSqlRaw("Select * from  TIPO_VEICULO ").ToListAsync();
            await _context.UtilizadorModel.FromSqlRaw("Select * from  UTILIZADOR ").ToListAsync();

            if (id == null)
            {
                return NotFound();
            }

            var anuncio = await _context.AnuncioModel
                .FirstOrDefaultAsync(m => m.IDANUNCIO == id);
            if (anuncio == null)
            {
                return NotFound();
            }
            ViewBag.idanuncio = id;
            return View(anuncio);
        } 

        [Authorize(Roles = "1")]
        public IActionResult Secured()
        {
            
            return View();
        }     
        
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        } 
        
        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }  
      
        [HttpPost("login")]
        public async Task<IActionResult> Validate(string username, string password, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var utilizador = _context.UserModel.FromSqlRaw("Select * from UTILIZADOR where EMAIL = {0} and PASSE = {1} ORDER BY ID_UTILIZADOR ASC",username,password).ToListAsync();
            if (utilizador.Result.Count>0)
            {
                
                var claims = new List<Claim>();
                claims.Add(new Claim("username",utilizador.Result.First().nome));
                claims.Add(new Claim(ClaimTypes.NameIdentifier,utilizador.Result.First().IDUTILIZADOR.ToString()));
                claims.Add(new Claim(ClaimTypes.Name,utilizador.Result.First().email));
                claims.Add(new Claim(ClaimTypes.Role,utilizador.Result.First().tipoutilizador.ToString()));
                var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return Redirect(returnUrl);
            }

            TempData["Error"] = "Error. Username ou password erradas";
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}