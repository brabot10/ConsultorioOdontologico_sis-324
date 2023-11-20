using System;
using System.Collections.Generic;

namespace WebConsultorioOdontologicoMVC.Models;

public partial class Medicamento
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int IdInventario { get; set; }

    public decimal Cantidad { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Total { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Inventario IdInventarioNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
