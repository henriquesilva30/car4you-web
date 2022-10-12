using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace car4you.Models
{
    
    [Table("COMBUSTIVEL")]
    
    public class Combustivel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        //[Key,Column("ID_COMBUSTIVEL")] public IEnumerable<Anuncio> IDdCOMBUSTIVEL { get; set; }

        [Key,Column("ID_COMBUSTIVEL")] public int IDdCOMBUSTIVEL { get; set; }
        [Column("DESIGNACAO")] public string designacao { get; set; }
        
      //  public static List<SelectListItem> Employees { set; get; }

   //    public  ICollection<Anuncio> Anuncios { get; set; }
       }
}