using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car4you.Models
{
    [Table("MODELO")]

    
    public class Modelo
    {
        [Key,Column("ID_MODELO")] public int IDMODELO { get; set; }
        
        [Column("DESIGNACAO")] public string designacao { get; set; }
        
        [Column("ID_MARCA")] public string marca { get; set; }

    }
}