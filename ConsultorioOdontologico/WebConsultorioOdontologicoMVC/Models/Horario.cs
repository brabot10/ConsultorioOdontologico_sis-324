using System;
using System.Collections.Generic;

namespace WebConsultorioOdontologicoMVC.Models;

public partial class Horario
{
    public int Id { get; set; }

    public int IdPersonal { get; set; }

    public string Lunes { get; set; } = null!;

    public string Martes { get; set; } = null!;

    public string Miercoles { get; set; } = null!;

    public string Jueves { get; set; } = null!;

    public string Viernes { get; set; } = null!;

    public string Sabado { get; set; } = null!;

    public string Mes { get; set; } = null!;

    public DateTime Permiso { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Personal IdPersonalNavigation { get; set; } = null!;
}
