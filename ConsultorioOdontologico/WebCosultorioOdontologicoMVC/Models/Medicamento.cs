using System;
using System.Collections.Generic;

namespace WebCosultorioOdontologicoMVC.Models;

public partial class Medicamento
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public string Articulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public decimal Precio { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
