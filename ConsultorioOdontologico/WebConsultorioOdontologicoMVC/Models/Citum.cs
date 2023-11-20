using System;
using System.Collections.Generic;

namespace WebConsultorioOdontologicoMVC.Models;

public partial class Citum
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int IdRegistro { get; set; }

    public DateTime Fecha { get; set; }

    public TimeSpan Hora { get; set; }

    public string Tratamiento { get; set; } = null!;

    public string Pago { get; set; } = null!;

    public string ACuenta { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual Registro IdRegistroNavigation { get; set; } = null!;
}
