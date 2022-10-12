using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace car4you.Models
{
    [Table("TIPO_DESGASTE")]
    
    public class Desgaste
    {
        [Key,Column("ID_DESGASTE")] public int IDDESGASTE { get; set; }

        [Column("DESIGNACAO")] public string designacao { get; set; }
    }
}