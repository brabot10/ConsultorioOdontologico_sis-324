using System;
using System.Collections.Generic;

namespace WebConsultorioOdontologicoMVC.Models;

public partial class Personal
{
    public int Id { get; set; }

    public string CedulaIdentidad { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string? Especialidad { get; set; }

    public string? Antiguedad { get; set; }

    public string Direccion { get; set; } = null!;

    public long Celular { get; set; }

    public string Cargo { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
