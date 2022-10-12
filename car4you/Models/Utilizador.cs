using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace car4you.Models
{
    [Table("UTILIZADOR")]
    public class Utilizador
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key,Column("ID_UTILIZADOR")] public int IDUTILIZADOR { get; set; }

        [Column("NOME")] public string nome { get; set; }
        [Column("DISTRITO")] public string distrito { get; set; }
        [Column("CIDADE")] public string cidade { get; set; }
        [Column("MORADA")] public string morada { get; set; }
        [Column("PORTA_ANDAR")] public string portaAndar { get; set; }
        [Column("COD_POSTAL")] public string codPostal { get; set; }
        [Column("NIF")] public int nif { get; set; }
        [Column("TELEMOVEL")] public int telemovel { get; set; }
        [Column("TIPO_UTILIZADOR")] public int? tipoutilizador { get; set; } 
        [Column("EMAIL")] public string email { get; set; }
        [Column("PASSE")] public string passe { get; set; }
    }
}