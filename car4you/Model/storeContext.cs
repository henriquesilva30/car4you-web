using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using car4you.Models;

#nullable enable

namespace car4you.Model
{
    public partial class storeContext : DbContext
    {
        public storeContext()
        {
        }

        public storeContext(DbContextOptions<storeContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 //optionsBuilder.UseOracle(@"User Id=car4you;Password=qwerty2000;Data Source=ORDBC1;");
                // Database.EnsureCreated();
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<Utilizador>().ToTable("UTILIZADOR");
        //   modelBuilder.Entity<Utilizador>()
         //      .HasKey(i => i.IDUTILIZADOR);
        //   modelBuilder.Entity<Combustivel>()
         //      .HasKey(i => i.IDdCOMBUSTIVEL);
       //    modelBuilder.Entity<Anuncio>()
         //      .HasKey(i => i.IDANUNCIO);
       //    modelBuilder.Entity<AnuncioVer>()
         //      .HasKey(i => i.IDANUNCIO);
         //  modelBuilder.Entity<Anuncio>().HasOne(p => p.Combustivel).
          //    WithMany(b=>b.Anuncios).HasForeignKey(p=>p.desCombustivel).HasConstraintName("ANUNCIO_COMBUSTIVEL"); 
       
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<car4you.Models.Utilizador> UserModel { get; set; }

        public DbSet<car4you.Models.Anuncio> AnuncioModel { get; set; }


        public DbSet<car4you.Models.Denuncia> DenunciaModel { get; set; }
        
        public DbSet<car4you.Models.Combustivel> CombustivelModel { get; set; }
        public DbSet<car4you.Models.Estado> EstadoModel { get; set; }
        public DbSet<car4you.Models.Desgaste> DesgasteModel { get; set; }
        public DbSet<car4you.Models.Modelo> ModeloModel { get; set; }
        public DbSet<car4you.Models.Segmento> SegmentoModel { get; set; }
        public DbSet<car4you.Models.TipoVeiculo> TipoVeiculoModel { get; set; }
        public DbSet<car4you.Models.Utilizador> UtilizadorModel { get; set;}
    }
}
