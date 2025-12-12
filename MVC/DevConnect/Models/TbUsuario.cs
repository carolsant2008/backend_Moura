using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Models;

[Table("tb_usuario")]
[Index("Email", Name = "UQ__tb_usuar__AB6E61646E0401A1", IsUnique = true)]
[Index("NomeUsuario", Name = "UQ__tb_usuar__CCB80B0A329B3CE5", IsUnique = true)]
public partial class TbUsuario
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("nome_completo")]
    [StringLength(255)]
    public string NomeCompleto { get; set; } = null!;

    [Column("nome_usuario")]
    [StringLength(50)]
    public string NomeUsuario { get; set; } = null!;

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("senha")]
    [StringLength(50)]
    public string Senha { get; set; } = null!;

    [Column("foto_perfil_url")]
    [StringLength(150)]
    public string? FotoPerfilUrl { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbComentario> TbComentario { get; set; } = new List<TbComentario>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbCurtida> TbCurtida { get; set; } = new List<TbCurtida>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<TbPublicacao> TbPublicacao { get; set; } = new List<TbPublicacao>();

    [ForeignKey("UsuarioSeguidorId")]
    [InverseProperty("UsuarioSeguidor")]
    public virtual ICollection<TbUsuario> UsuarioSeguido { get; set; } = new List<TbUsuario>();

    [ForeignKey("UsuarioSeguidoId")]
    [InverseProperty("UsuarioSeguido")]
    public virtual ICollection<TbUsuario> UsuarioSeguidor { get; set; } = new List<TbUsuario>();
}
