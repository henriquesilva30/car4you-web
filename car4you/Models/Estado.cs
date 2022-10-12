using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car4you.Models
{
    [Table("ESTADO_ANUNCIO")]
    
    public class Estado
    {
        [Key,Column("ID_ESTADO")] public int IDESTADO { get; set; }
        
        [Column("DESIGNACAO")] public string designacao { get; set; }
    }
}