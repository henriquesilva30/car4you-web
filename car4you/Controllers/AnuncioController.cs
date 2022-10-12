using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using car4you.Model;
using car4you.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;

namespace car4you.Controllers
{
    public class AnuncioController : Controller
    {
        
        
        
        private readonly storeContext _context;

        public AnuncioController(storeContext context)
        {
            _context = context;
        }

        // GET: Anuncio
        [Authorize]
        public async Task<IActionResult> Index()
        {
            

           
                    var claimsIdentity = User.Identity as ClaimsIdentity;


                   var id_user = claimsIdentity.Claims.ElementAt(1).Value;
                  

           await _context.CombustivelModel.FromSqlRaw("Select * from  COMBUSTIVEL ").ToListAsync();
           await _context.EstadoModel.FromSqlRaw("Select * from  ESTADO_ANUNCIO ").ToListAsync();
           await _context.DesgasteModel.FromSqlRaw("Select * from TIPO_DESGASTE").ToListAsync();
           await _context.ModeloModel.FromSqlRaw("Select * from  MODELO ").ToListAsync();
           await _context.SegmentoModel.FromSqlRaw("Select * from  TIPO_SEGMENTO ").ToListAsync();
           await _context.TipoVeiculoModel.FromSqlRaw("Select * from  TIPO_VEICULO ").ToListAsync();
           await _context.UtilizadorModel.FromSqlRaw("Select * from  UTILIZADOR ").ToListAsync();
           var anuncios =await _context.AnuncioModel.FromSqlRaw("Select * from ANUNCIO where ID_UTILIZADOR = {0} ORDER BY ID_Anuncio ASC", Int32.Parse(id_user) ).ToListAsync();
         
          
          return View(anuncios);
        }
        

        // GET: Anuncio/Details/5
        [Authorize]
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
            return View(anuncio);
        }
        
        // GET: Anuncio/Create
        [Authorize]
        public IActionResult Create()
        {
            var estados = _context.EstadoModel.FromSqlRaw("Select * from ESTADO_ANUNCIO").ToList();
            var desgastes = _context.DesgasteModel.FromSqlRaw("Select * from TIPO_DESGASTE").ToList();
            var modelos = _context.ModeloModel.FromSqlRaw("Select * from  MODELO ").ToList();
            var segmentos = _context.SegmentoModel.FromSqlRaw("Select * from  TIPO_SEGMENTO ").ToList();
            var tipoveiculos = _context.TipoVeiculoModel.FromSqlRaw("Select * from  TIPO_VEICULO ").ToList();
            var combustiveis = _context.CombustivelModel.FromSqlRaw("Select * from COMBUSTIVEL").ToList();
            List<SelectListItem> estado = new List<SelectListItem>();
            List<SelectListItem> modelo = new List<SelectListItem>();
            List<SelectListItem> desgate = new List<SelectListItem>();
            List<SelectListItem> tipo_veiculo = new List<SelectListItem>();
            List<SelectListItem> segmento= new List<SelectListItem>();
            List<SelectListItem> combustivei= new List<SelectListItem>();
          
            for(int i=1; combustiveis.Count >=i;i++)
            {
                combustivei.Insert(0, new SelectListItem() { Value = _context.CombustivelModel.Find(i).IDdCOMBUSTIVEL.ToString(), Text = _context.CombustivelModel.Find(i).designacao});

            }
            for(int i=1; estados.Count >=i;i++)
            {
                estado.Insert(0, new SelectListItem() { Value = _context.EstadoModel.Find(i).IDESTADO.ToString(), Text = _context.EstadoModel.Find(i).designacao});
            }  
            for(int i=1; modelos.Count >=i;i++)
            {
                modelo.Insert(0, new SelectListItem() { Value = _context.ModeloModel.Find(i).IDMODELO.ToString(), Text = _context.ModeloModel.Find(i).designacao});
            }  
            for(int i=1; segmentos.Count >=i;i++)
            {
                segmento.Insert(0, new SelectListItem() { Value = _context.SegmentoModel.Find(i).IDSEGMENTO.ToString(), Text = _context.SegmentoModel.Find(i).designacao});

            } 
            for(int i=1; desgastes.Count >=i;i++)
            {
                desgate.Insert(0, new SelectListItem() { Value = _context.DesgasteModel.Find(i).IDDESGASTE.ToString(), Text = _context.DesgasteModel.Find(i).designacao});
            }
            for(int i=1; tipoveiculos.Count >=i;i++)
            {
                tipo_veiculo.Insert(0, new SelectListItem() { Value = _context.TipoVeiculoModel.Find(i).IDTIPOVEICULO.ToString(), Text = _context.TipoVeiculoModel.Find(i).designacao});
            } 
           
          //  combustivei.Add("asdsadsad");
            // combustivei.Add("azul");
            ViewBag.CombList = new List<SelectListItem>(combustivei);
            ViewBag.SegList = new List<SelectListItem>(segmento);
            ViewBag.DesgList = new List<SelectListItem>(desgate);   
            ViewBag.ModeList = new List<SelectListItem>(modelo);
            ViewBag.EstList = new List<SelectListItem>(estado);
            ViewBag.TpveicList = new List<SelectListItem>(tipo_veiculo);
            return View();
        }

        // POST: Anuncio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int Combustivel,int Modelo, int Desgaste,int Segmento, string designacao, string url,string descricao, int lotacao, string renegociar,double valor, string cor, int nporta,string caixa, string matricula, int ano, int cilindrada,int potencia, int kms, Anuncio anuncio)
        {
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var id_user = claimsIdentity.Claims.ElementAt(1).Value;
            await _context.CombustivelModel.FromSqlRaw("Select * from  COMBUSTIVEL ").ToListAsync();
            await _context.EstadoModel.FromSqlRaw("Select * from  ESTADO_ANUNCIO ").ToListAsync();
            await _context.DesgasteModel.FromSqlRaw("Select * from TIPO_DESGASTE").ToListAsync();
            await _context.ModeloModel.FromSqlRaw("Select * from  MODELO ").ToListAsync();
            await _context.SegmentoModel.FromSqlRaw("Select * from  TIPO_SEGMENTO ").ToListAsync();
            await _context.TipoVeiculoModel.FromSqlRaw("Select * from  TIPO_VEICULO ").ToListAsync();
            await _context.UtilizadorModel.FromSqlRaw("Select * from  UTILIZADOR ").ToListAsync();
            var datacriado= DateTime.Now.ToString("yyyy.MM.dd tt");
            TimeSpan tSpan = new TimeSpan(30, 0, 0, 0);
            var datafimdata= DateTime.Now + tSpan;
            var datafim= datafimdata.ToString("yyyy.MM.dd tt");
           // string str1 = "Insert Into  ANUNCIO(designacao,data_criado,url_video,descricao,renegociar,data_fim,valor,cor,n_portas,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,id_combustivel,id_estado,id_modelo,id_desgaste,id_segmento,id_tipo_veiculo,id_utilizador) Values(designacao,datacriado,url,descricao,renegociar,datafim,valor,cor,nporta,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,Combustivel,1,Modelo,Desgaste,Segmento,1,1)";
          //  string str1 = "Insert Into  ANUNCIO(designacao,data_criado,url_video,descricao,renegociar,data_fim,valor,cor,n_portas,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,id_combustivel,id_estado,id_modelo,id_desgaste,id_segmento,id_tipo_veiculo,id_utilizador) Values('zazazav','12/04/2010','sdfsdf','asdsadsad',1,'12/04/2020',23,'asdasd','asdsad','asdsad','sdfdsfdsf',2,2020,222,222,222,1,1,1,1,1,1,1)";
        //  string str=String.Format("Insert Into  ANUNCIO(designacao,url_video,descricao,renegociar,valor,cor,n_portas,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,id_combustivel,id_estado,id_modelo,id_desgaste,id_segmento,id_tipo_veiculo,id_utilizador) Values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},1,{15},{16},{17},1,1)",designacao,url,descricao,renegociar,valor,cor,nporta,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,Combustivel,Modelo,Desgaste,Segmento);
         // await _context.Database.ExecuteSqlRawAsync("Insert Into  ANUNCIO(designacao,url_video,descricao,renegociar,valor,cor,n_portas,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,id_combustivel,id_estado,id_modelo,id_desgaste,id_segmento,id_tipo_veiculo,id_utilizador) Values('qwertyz','sadsad','sadsda',1,1,1,1,1,1,1,1,1,1,1,1,1,4,1,1,1,1)");
         // await _context.Database.ExecuteSqlRawAsync("Insert Into  ANUNCIO(designacao,data_criado,url_video,descricao,renegociar,data_fim,valor,cor,n_portas,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,id_combustivel,id_estado,id_modelo,id_desgaste,id_segmento,id_tipo_veiculo,id_utilizador) Values({0},'22.10.20',{1},{2},{3},'26.12.21',{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},1,{15},{16},{17},1,1)",designacao,url,descricao,renegociar,valor,cor,nporta,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,Combustivel,Modelo,Desgaste,Segmento);
          _context.Database.ExecuteSqlRaw("Insert Into  ANUNCIO(designacao,data_criado,url_video,descricao,renegociar,data_fim,valor,cor,n_portas,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,id_combustivel,id_estado,id_modelo,id_desgaste,id_segmento,id_tipo_veiculo,id_utilizador) Values({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},4,{17},{18},{19},1,{20})",designacao,datacriado,url,descricao,renegociar,datafim,valor,cor,nporta,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,Combustivel,Modelo,Desgaste,Segmento,Int32.Parse(id_user));
            /*   if (ModelState.IsValid)
               {
                   _context.Add(anuncio);
                   await _context.SaveChangesAsync();
                   return RedirectToAction(nameof(Index));
               }*/
         //   return View(anuncio);
         await _context.AnuncioModel.FromSqlRaw("Select * from ANUNCIO where ID_UTILIZADOR = {0} ORDER BY ID_Anuncio ASC", Int32.Parse(id_user) ).ToListAsync();
         return RedirectToAction("Index", "Anuncio");
        }

        // GET: Anuncio/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            var estados = _context.EstadoModel.FromSqlRaw("Select * from ESTADO_ANUNCIO").ToList();
            var desgastes = _context.DesgasteModel.FromSqlRaw("Select * from TIPO_DESGASTE").ToList();
            var modelos = _context.ModeloModel.FromSqlRaw("Select * from  MODELO ").ToList();
            var segmentos = _context.SegmentoModel.FromSqlRaw("Select * from  TIPO_SEGMENTO ").ToList();
            var combustiveis = _context.CombustivelModel.FromSqlRaw("Select * from COMBUSTIVEL").ToList();
            List<SelectListItem> estado = new List<SelectListItem>();
            List<SelectListItem> modelo = new List<SelectListItem>();
            List<SelectListItem> desgate = new List<SelectListItem>();
            List<SelectListItem> segmento= new List<SelectListItem>();
            List<SelectListItem> combustivei= new List<SelectListItem>();
            var anuncio = await _context.AnuncioModel.FindAsync(id);
            for(int i=1; combustiveis.Count >=i;i++)
            { 
                combustivei.Insert(0, new SelectListItem() { Value = _context.CombustivelModel.Find(i).IDdCOMBUSTIVEL.ToString(), Text = _context.CombustivelModel.Find(i).designacao});
            }
            for(int i=1; estados.Count >=i;i++)
            {
                estado.Insert(0, new SelectListItem() { Value = _context.EstadoModel.Find(i).IDESTADO.ToString(), Text = _context.EstadoModel.Find(i).designacao});
            }  
            for(int i=1; modelos.Count >=i;i++)
            {
                modelo.Insert(0, new SelectListItem() { Value = _context.ModeloModel.Find(i).IDMODELO.ToString(), Text = _context.ModeloModel.Find(i).designacao});
            }  
            for(int i=1; segmentos.Count >=i;i++)
            {
                segmento.Insert(0, new SelectListItem() { Value = _context.SegmentoModel.Find(i).IDSEGMENTO.ToString(), Text = _context.SegmentoModel.Find(i).designacao});

            } 
            for(int i=1; desgastes.Count >=i;i++)
            {
                desgate.Insert(0, new SelectListItem() { Value = _context.DesgasteModel.Find(i).IDDESGASTE.ToString(), Text = _context.DesgasteModel.Find(i).designacao});
            }

            if (id == null)
            {
                return NotFound();
            }

         
            if (anuncio == null)
            {
                return NotFound();
            }
            ViewBag.CombList = new List<SelectListItem>(combustivei);
            ViewBag.SegList = new List<SelectListItem>(segmento);
            ViewBag.DesgList = new List<SelectListItem>(desgate);   
            ViewBag.ModeList = new List<SelectListItem>(modelo);
            ViewBag.EstList = new List<SelectListItem>(estado);
            ViewBag.ValueToSetcomb = _context.CombustivelModel.Find(anuncio.Combustivel.IDdCOMBUSTIVEL).IDdCOMBUSTIVEL.ToString();
            ViewBag.ValueToSetmodel = _context.ModeloModel.Find(anuncio.Modelo.IDMODELO).IDMODELO.ToString();
            ViewBag.ValueToSetdesg = _context.DesgasteModel.Find(anuncio.Desgaste.IDDESGASTE).IDDESGASTE.ToString();
            ViewBag.ValueToSetseg = _context.SegmentoModel.Find(anuncio.Segmento.IDSEGMENTO).IDSEGMENTO.ToString();
            return View(anuncio);
        }

        // POST: Anuncio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Combustivel,int Modelo, int Desgaste,int Segmento, string designacao, string url,string descricao, int lotacao, string renegociar,double valor, string cor, int nporta,string caixa, string matricula, int ano, int cilindrada,int potencia, int kms,int? id)
        {
            
            var claimsIdentity = User.Identity as ClaimsIdentity;
            var id_user = claimsIdentity.Claims.ElementAt(1).Value;
            await _context.CombustivelModel.FromSqlRaw("Select * from  COMBUSTIVEL ").ToListAsync();
            await _context.EstadoModel.FromSqlRaw("Select * from  ESTADO_ANUNCIO ").ToListAsync();
            await _context.DesgasteModel.FromSqlRaw("Select * from TIPO_DESGASTE").ToListAsync();
            await _context.ModeloModel.FromSqlRaw("Select * from  MODELO ").ToListAsync();
            await _context.SegmentoModel.FromSqlRaw("Select * from  TIPO_SEGMENTO ").ToListAsync();
            await _context.TipoVeiculoModel.FromSqlRaw("Select * from  TIPO_VEICULO ").ToListAsync();
            await _context.UtilizadorModel.FromSqlRaw("Select * from  UTILIZADOR ").ToListAsync();
            
            _context.Database.ExecuteSqlRaw("Update ANUNCIO set designacao={0},url_video={1},descricao={2},renegociar={3},valor={4},cor={5},n_portas={6},caixa={7},matricula={8},lotacao={9},ano={10},cilindrada={11},potencia={12},kms={13},id_combustivel={14},id_estado=4,id_modelo={15},id_desgaste={16},id_segmento={17},id_tipo_veiculo=4 where id_anuncio={18}",designacao,url,descricao,renegociar,valor,cor,nporta,caixa,matricula,lotacao,ano,cilindrada,potencia,kms,Combustivel,Modelo,Desgaste,Segmento,id);
            
            await _context.AnuncioModel.FromSqlRaw("Select * from ANUNCIO where ID_UTILIZADOR = {0} ORDER BY ID_Anuncio ASC", Int32.Parse(id_user) ).ToListAsync();
            return RedirectToAction("Index", "Anuncio");
        }

        // GET: Anuncio/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
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

            return View(anuncio);
        }

        // POST: Anuncio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var anuncio = await _context.AnuncioModel.FindAsync(id);
            _context.AnuncioModel.Remove(anuncio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnuncioExists(int id)
        {
            return _context.AnuncioModel.Any(e => e.IDANUNCIO == id);
        }
    }
}
