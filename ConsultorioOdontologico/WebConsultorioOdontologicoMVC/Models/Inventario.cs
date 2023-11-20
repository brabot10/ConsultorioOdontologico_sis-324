using System;
using System.Collections.Generic;

namespace WebConsultorioOdontologicoMVC.Models;

public partial class Inventario
{
    public int Id { get; set; }

    public string Articulo { get; set; } = null!;

    public decimal Precio { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();
}
