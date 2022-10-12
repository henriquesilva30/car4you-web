using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car4you.Models
{
    
    [Table("DENUNCIA")]

    
    public class Denuncia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key,Column("ID_DENUNCIA")] public int IDDENUNCIA { get; set; }
        [Column("DESCRICAO")] public string descricao { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("DATAD")]
        public DateTime data { get; set; } = DateTime.Now;
        [Column("RELSOVIDO")] public int resolvido { get; set; }
        [Column("TITULO")] public string titulo { get; set; }
        [Column("VISTO")] public int visto { get; set; }
        [ForeignKey("ID_ANUNCIO"),Column("ID_ANUNCIO")] public Anuncio Anuncio { get; set; }

      
        
    }
}