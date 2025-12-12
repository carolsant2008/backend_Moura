using System;
using System.Collections.Generic;
using DevConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comentario> Comentario { get; set; }

    public virtual DbSet<Curtida> Curtida { get; set; }

    public virtual DbSet<Publicacao> Publicacao { get; set; }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtida> TbCurtida { get; set; }

    public virtual DbSet<TbDevconnect> TbDevconnect { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_SA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Comentar__3213E83FC23AE6BC");

            entity.HasOne(d => d.Publicacao).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Comentario_publicacao");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Comentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Comentario_usuario");
        });

        modelBuilder.Entity<Curtida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Curtida__3213E83F2751992F");

            entity.HasOne(d => d.Publicacao).WithMany(p => p.Curtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Curtida_publicacao");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Curtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Curtida_usuario");
        });

        modelBuilder.Entity<Publicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Publicac__3213E83FB15AD6B5");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Publicacao).HasConstraintName("fk_Publicacao_usuario");
        });

        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.IdComentario).HasName("PK__tb_comen__1BA6C6F4E19E7FB3");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_pu__5535A963");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentario).HasConstraintName("FK__tb_coment__id_us__5441852A");
        });

        modelBuilder.Entity<TbCurtida>(entity =>
        {
            entity.HasKey(e => e.IdCurtida).HasName("PK__tb_curti__0AC033CA3801261D");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_pu__5165187F");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_us__5070F446");
        });

        modelBuilder.Entity<TbDevconnect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_devco__3213E83F4161A8B4");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_publi__3213E83FDA930D92");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__4D94879B");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83FFFEA3452");

            entity.HasMany(d => d.UsuarioSeguido).WithMany(p => p.UsuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__seguidor__Usuari__51300E55"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__seguidor__Usuari__503BEA1C"),
                    j =>
                    {
                        j.HasKey("UsuarioSeguidorId", "UsuarioSeguidoId").HasName("PK__seguidor__475A2EF3794EA333");
                        j.ToTable("seguidor");
                    });

            entity.HasMany(d => d.UsuarioSeguidor).WithMany(p => p.UsuarioSeguido)
                .UsingEntity<Dictionary<string, object>>(
                    "Seguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__seguidor__Usuari__503BEA1C"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("UsuarioSeguidoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__seguidor__Usuari__51300E55"),
                    j =>
                    {
                        j.HasKey("UsuarioSeguidorId", "UsuarioSeguidoId").HasName("PK__seguidor__475A2EF3794EA333");
                        j.ToTable("seguidor");
                    });
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F92E494D2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
