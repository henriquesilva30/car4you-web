using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car4you.Models
{
    [Table("TIPO_VEICULO")]
    
    public class TipoVeiculo
    {
        [Key,Column("ID_TIPO_VEICULO")] public int IDTIPOVEICULO { get; set; }
        
        [Column("DESIGNACAO")] public string designacao { get; set; }
    }
}