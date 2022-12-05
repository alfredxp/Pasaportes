using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PasaportesApiSol.Models;

public partial class PasaportesDbContext : DbContext
{
    public PasaportesDbContext()
    {
    }

    public PasaportesDbContext(DbContextOptions<PasaportesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<LogsSolicitude> LogsSolicitudes { get; set; }

    public virtual DbSet<Oficina> Oficinas { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Pasaporte> Pasaportes { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Solicitude> Solicitudes { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PasaportesDB;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.EstadoId).HasName("PK__Estado__FEF86B606DCE3DE9");

            entity.ToTable("Estado");

            entity.Property(e => e.EstadoId).HasColumnName("EstadoID");
            entity.Property(e => e.EstadoCodigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EstadoTipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.HasKey(e => e.ImpuestoId).HasName("PK__Impuesto__CD9F45DECF859C6A");

            entity.Property(e => e.ImpuestoId).HasColumnName("ImpuestoID");
            entity.Property(e => e.ImpuestoCodigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ImpuestoDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.ImpuestoEstadoNavigation).WithMany(p => p.Impuestos)
                .HasForeignKey(d => d.ImpuestoEstado)
                .HasConstraintName("FK__Impuestos__Impue__30F848ED");
        });

        modelBuilder.Entity<LogsSolicitude>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__LogsSoli__5E5499A838B9D56F");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.LogDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogFecha).HasColumnType("datetime");
            entity.Property(e => e.LogSolicitudesId).HasColumnName("LogSolicitudesID");

            entity.HasOne(d => d.LogSolicitudes).WithMany(p => p.LogsSolicitudes)
                .HasForeignKey(d => d.LogSolicitudesId)
                .HasConstraintName("FK__LogsSolic__LogSo__3B75D760");
        });

        modelBuilder.Entity<Oficina>(entity =>
        {
            entity.HasKey(e => e.OficinaId).HasName("PK__Oficinas__E86F5FCC19C223B1");

            entity.Property(e => e.OficinaId).HasColumnName("OficinaID");
            entity.Property(e => e.OficinaDireccion).IsUnicode(false);
            entity.Property(e => e.OficinaNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OficinaTelefono)
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.HasOne(d => d.OficinaEstadoNavigation).WithMany(p => p.Oficinas)
                .HasForeignKey(d => d.OficinaEstado)
                .HasConstraintName("FK__Oficinas__Oficin__2E1BDC42");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.PagoId).HasName("PK__Pagos__F00B615860CBDB0D");

            entity.Property(e => e.PagoId).HasColumnName("PagoID");
            entity.Property(e => e.PagoCreacion).HasColumnType("datetime");
            entity.Property(e => e.PagoFecha).HasColumnType("datetime");
            entity.Property(e => e.PagoImagen).HasColumnType("image");
            entity.Property(e => e.PagoMetodo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PagoMonto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PagoRecibo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PagoReferencia)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.PagoEstadoNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.PagoEstado)
                .HasConstraintName("FK__Pagos__PagoEstad__33D4B598");
        });

        modelBuilder.Entity<Pasaporte>(entity =>
        {
            entity.HasKey(e => e.PasaporteId).HasName("PK__Pasaport__EA58D4ED3074DF13");

            entity.Property(e => e.PasaporteId).HasColumnName("PasaporteID");
            entity.Property(e => e.PasaporteApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PasaporteCedula)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.PasaporteCodigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PasaporteCorreo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PasaporteDescripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PasaporteDireccion)
                .HasMaxLength(400)
                .IsUnicode(false);
            entity.Property(e => e.PasaporteEstadoId).HasColumnName("PasaporteEstadoID");
            entity.Property(e => e.PasaporteFechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.PasaporteImage).HasColumnType("image");
            entity.Property(e => e.PasaporteNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PasaporteSolicitudId).HasColumnName("PasaporteSolicitudID");

            entity.HasOne(d => d.PasaporteEstado).WithMany(p => p.Pasaportes)
                .HasForeignKey(d => d.PasaporteEstadoId)
                .HasConstraintName("FK__Pasaporte__Pasap__3F466844");

            entity.HasOne(d => d.PasaporteSolicitud).WithMany(p => p.Pasaportes)
                .HasForeignKey(d => d.PasaporteSolicitudId)
                .HasConstraintName("FK__Pasaporte__Pasap__3E52440B");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__Roles__F92302D1DE5ECE77");

            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.RolDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RolNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Solicitude>(entity =>
        {
            entity.HasKey(e => e.SolicitudId).HasName("PK__Solicitu__85E95DA7D877F1BB");

            entity.Property(e => e.SolicitudId).HasColumnName("SolicitudID");
            entity.Property(e => e.SolicitudFecha).HasColumnType("datetime");
            entity.Property(e => e.SolicitudFechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.SolicitudFechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.SolicitudNombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SolicitudEstadoNavigation).WithMany(p => p.Solicitudes)
                .HasForeignKey(d => d.SolicitudEstado)
                .HasConstraintName("FK__Solicitud__Solic__38996AB5");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE79848E2B9ED");

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.PasaporteId).HasColumnName("PasaporteID");
            entity.Property(e => e.UsuarioApellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCedula)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCelular)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCorreo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioEstadoId).HasColumnName("UsuarioEstadoID");
            entity.Property(e => e.UsuarioFechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.UsuarioHash)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioLogin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioPassword)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioRolId).HasColumnName("UsuarioRolID");
            entity.Property(e => e.UsuarioSalt)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioSexo)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioTelefono)
                .HasMaxLength(12)
                .IsUnicode(false);

            entity.HasOne(d => d.Pasaporte).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.PasaporteId)
                .HasConstraintName("FK__Usuarios__Pasapo__440B1D61");

            entity.HasOne(d => d.UsuarioEstado).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.UsuarioEstadoId)
                .HasConstraintName("FK__Usuarios__Usuari__4222D4EF");

            entity.HasOne(d => d.UsuarioRol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.UsuarioRolId)
                .HasConstraintName("FK__Usuarios__Usuari__4316F928");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
