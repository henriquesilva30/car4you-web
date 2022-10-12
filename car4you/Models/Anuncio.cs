using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Query;


namespace car4you.Models
{
    [Table("ANUNCIO")]

    public class Anuncio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key,Column("ID_ANUNCIO")] public int IDANUNCIO { get; set; }

        [Column("DESIGNACAO")] public string designacao { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("DATA_CRIADO")] public DateTime datacriado { get; set; } = DateTime.Now;
        [AllowNull,Column("URL_VIDEO")] public string url { get; set; }
        [Column("DESCRICAO")] public string descricao { get; set; }
        [Column("RENEGOCIAR")] public string renegociar { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("DATA_FIM")] public DateTime datafim { get; set; }
        [Column("VALOR")] public double valor { get; set; }
        [AllowNull,Column("COR")] public string cor { get; set; }
        [AllowNull,Column("N_PORTAS")] public int nporta { get; set; }
        [Column("CAIXA")] public string caixa { get; set; } 
        [AllowNull,Column("MATRICULA")] public string matricula { get; set; }
        [AllowNull,Column("LOTACAO")] public int lotacao { get; set; }
        [Column("ANO")] public int ano { get; set; }
        [Column("CILINDRADA")] public int cilindrada { get; set; }
        [Column("POTENCIA")] public int potencia { get; set; }     
        [Column("KMS")] public int kms { get; set; } [ForeignKey("ID_COMBUSTIVEL"),Column("ID_COMBUSTIVEL")]  public virtual Combustivel Combustivel { get; set; }
       [ForeignKey("ID_ESTADO"),Column("ID_ESTADO")] public virtual Estado Estado { get; set; }
        [ForeignKey("ID_MODELO"),Column("ID_MODELO")] public virtual Modelo Modelo { get; set; }
        [ForeignKey("ID_DESGASTE"),Column("ID_DESGASTE")] public virtual Desgaste Desgaste { get; set; }
        [ForeignKey("ID_SEGMENTO"),Column("ID_SEGMENTO")] public virtual Segmento Segmento { get; set; }
        [ForeignKey("ID_TIPO_VEICULO"),Column("ID_TIPO_VEICULO")] public virtual TipoVeiculo TipoVeiculo { get; set; }
        [ForeignKey("ID_UTILIZADOR"),Column("ID_UTILIZADOR")] public virtual Utilizador Utilizador { get; set; }
    }
}