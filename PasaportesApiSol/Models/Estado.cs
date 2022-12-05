using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Estado
{
    public int EstadoId { get; set; }

    public string? EstadoNombre { get; set; }

    public string? EstadoTipo { get; set; }

    public string? EstadoCodigo { get; set; }

    public virtual ICollection<Impuesto> Impuestos { get; } = new List<Impuesto>();

    public virtual ICollection<Oficina> Oficinas { get; } = new List<Oficina>();

    public virtual ICollection<Pago> Pagos { get; } = new List<Pago>();

    public virtual ICollection<Pasaporte> Pasaportes { get; } = new List<Pasaporte>();

    public virtual ICollection<Solicitude> Solicitudes { get; } = new List<Solicitude>();

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
