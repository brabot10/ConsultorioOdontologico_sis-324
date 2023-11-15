using System;
using System.Collections.Generic;

namespace WebCosultorioOdontologicoMVC.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public int IdPersonal { get; set; }

    public string Nombres { get; set; } = null!;

    public string CedulaIdentidad { get; set; } = null!;

    public string? Alergias { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public long Celular { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual Personal IdPersonalNavigation { get; set; } = null!;

    public virtual ICollection<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();
}
