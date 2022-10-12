using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car4you.Models
{
    [Table("TIPO_SEGMENTO")]

    
    public class Segmento
    {
        [Key,Column("ID_SEGMENTO")] public int IDSEGMENTO { get; set; }
        
                [Column("DESIGNACAO")] public string designacao { get; set; }
    }
}