using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebConsultorioOdontologicoMVC.Models;

public partial class LabSis324Context : DbContext
{
    public LabSis324Context()
    {
    }

    public LabSis324Context(DbContextOptions<LabSis324Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<Registro> Registros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database= LabSis324;User ID= usrodontologia;Password=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cita__3213E83F84A075AC");

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
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.IdRegistro).HasColumnName("idRegistro");
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

            entity.HasOne(d => d.IdRegistroNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Cita_Registro");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Horario__3213E83F729862AE");

            entity.ToTable("Horario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdPersonal).HasColumnName("idPersonal");
            entity.Property(e => e.Jueves)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("jueves");
            entity.Property(e => e.Lunes)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("lunes");
            entity.Property(e => e.Martes)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("martes");
            entity.Property(e => e.Mes)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("mes");
            entity.Property(e => e.Miercoles)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("miercoles");
            entity.Property(e => e.Permiso)
                .HasColumnType("date")
                .HasColumnName("permiso");
            entity.Property(e => e.Sabado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("sabado");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
            entity.Property(e => e.Viernes)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("viernes");

            entity.HasOne(d => d.IdPersonalNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.IdPersonal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Horario_Personal");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Inventar__3213E83F037172D4");

            entity.ToTable("Inventario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Articulo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("articulo");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Medicame__3213E83FECB5F933");

            entity.ToTable("Medicamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("cantidad");
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
            entity.Property(e => e.IdInventario).HasColumnName("idInventario");
            entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");

            entity.HasOne(d => d.IdInventarioNavigation).WithMany(p => p.Medicamentos)
                .HasForeignKey(d => d.IdInventario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Medicamento_Inventario");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Medicamentos)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Medicamento_Paciente");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3213E83F354CC45F");

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
            entity.HasKey(e => e.Id).HasName("PK__Personal__3213E83F90EA9D21");

            entity.ToTable("Personal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Antiguedad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("antiguedad");
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
            entity.Property(e => e.Especialidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("especialidad");
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
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
        });

        modelBuilder.Entity<Registro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Registro__3213E83F64770799");

            entity.ToTable("Registro");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((1))")
                .HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.UsuarioRegistro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())")
                .HasColumnName("usuarioRegistro");
            entity.Property(e => e.Valor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83F4B7D094A");

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
