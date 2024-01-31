using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WSRmsUpdate.Modelo.DataBase;

public partial class WsrmsUpdateContext : DbContext
{
    public WsrmsUpdateContext()
    {
    }

    public WsrmsUpdateContext(DbContextOptions<WsrmsUpdateContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WstEstadoUsusario> WstEstadoUsusarios { get; set; }

    public virtual DbSet<WstTipoUsuario> WstTipoUsuarios { get; set; }

    public virtual DbSet<WstUsuario> WstUsuarios { get; set; }

    public virtual DbSet<WsvListaUsuario> WsvListaUsuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.1.9\\RMS;Database=WSRmsUpdate;User Id=WSRms;Password=AEGRmsSis1;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WstEstadoUsusario>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__wstEstad__40F9A207AC456969");

            entity.ToTable("wstEstadoUsusario");

            entity.Property(e => e.Codigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WstTipoUsuario>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("PK__wstTipoU__40F9A2074D749FE8");

            entity.ToTable("wstTipoUsuario");

            entity.Property(e => e.Codigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codigo");
            entity.Property(e => e.TipoPrivilegios)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WstUsuario>(entity =>
        {
            entity.HasKey(e => e.NumSec).HasName("PK__wstUsuar__C05B492F8E703E2C");

            entity.ToTable("wstUsuario");

            entity.Property(e => e.NumSec).HasColumnName("num_sec");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_Estado");
            entity.Property(e => e.CodTipoUsuario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cod_TipoUsuario");
            entity.Property(e => e.Correo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Elim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("elim");
            entity.Property(e => e.FchaCreacion)
                .HasColumnType("datetime")
                .HasColumnName("fchaCreacion");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Password)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UsrCreacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usrCreacion");
            entity.Property(e => e.UsrModif)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usrModif");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.WstUsuarios)
                .HasForeignKey(d => d.CodEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__wstUsuari__cod_E__398D8EEE");

            entity.HasOne(d => d.CodTipoUsuarioNavigation).WithMany(p => p.WstUsuarios)
                .HasForeignKey(d => d.CodTipoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__wstUsuari__cod_T__38996AB5");
        });

        modelBuilder.Entity<WsvListaUsuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsvListaUsuarios");

            entity.Property(e => e.Correo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumSec).HasColumnName("num_sec");
            entity.Property(e => e.TipoPrivilegios)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
