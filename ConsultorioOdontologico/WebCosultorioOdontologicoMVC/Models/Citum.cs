using System;
using System.Collections.Generic;

namespace WebCosultorioOdontologicoMVC.Models;

public partial class Citum
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public DateTime Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public string Tratamiento { get; set; } = null!;

    public string Pago { get; set; } = null!;

    public string ACuenta { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
