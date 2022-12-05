using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Pago
{
    public int PagoId { get; set; }

    public decimal? PagoMonto { get; set; }

    public string? PagoRecibo { get; set; }

    public DateTime? PagoFecha { get; set; }

    public string? PagoReferencia { get; set; }

    public string? PagoMetodo { get; set; }

    public DateTime? PagoCreacion { get; set; }

    public byte[]? PagoImagen { get; set; }

    public int? PagoEstado { get; set; }

    public virtual Estado? PagoEstadoNavigation { get; set; }
}
