using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebCosultorioOdontologicoMVC.Models;

public partial class LabConsultorioOdontologicoContext : DbContext
{
    public LabConsultorioOdontologicoContext()
    {
    }

    public LabConsultorioOdontologicoContext(DbContextOptions<LabConsultorioOdontologicoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database= LabConsultorioOdontologico;User ID= usrconsultorio;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cita__3213E83F97370C79");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ACuenta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("aCuenta");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Hora)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hora");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.Pago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pago");
            entity.Property(e => e.Tratamiento)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("tratamiento");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Cita_Paciente");
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Medicame__3213E83FFA49AF35");

            entity.ToTable("Medicamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Articulo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("articulo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Medicamentos)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Medicamento_Paciente");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3213E83F87E231C8");

            entity.ToTable("Paciente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alergias)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("alergias");
            entity.Property(e => e.CedulaIdentidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cedulaIdentidad");
            entity.Property(e => e.Celular).HasColumnName("celular");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("date")
                .HasColumnName("fechaNacimiento");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdPersonal).HasColumnName("idPersonal");
            entity.Property(e => e.Nombres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Paciente_Personal");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personal__3213E83FD08199B0");

            entity.ToTable("Personal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.CedulaIdentidad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cedulaIdentidad");
            entity.Property(e => e.Celular).HasColumnName("celular");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Nombres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.PrimerApellido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("primerApellido");
            entity.Property(e => e.SegundoApellido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("segundoApellido");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F3CFC3822");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Clave)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdPersonal).HasColumnName("idPersonal");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("usuario");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Usuario_Personal");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
