using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_devconnect")]
[Index("FotoLogoUrl", Name = "UQ__tb_devco__A7ED61E931381ABE", IsUnique = true)]
[Index("NomeDevconnect", Name = "UQ__tb_devco__D6A53907F5D8ACCD", IsUnique = true)]
public partial class TbDevconnect
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome_devconnect")]
    [StringLength(255)]
    public string NomeDevconnect { get; set; } = null!;

    [Column("foto_logo_url")]
    [StringLength(150)]
    public string FotoLogoUrl { get; set; } = null!;
}
