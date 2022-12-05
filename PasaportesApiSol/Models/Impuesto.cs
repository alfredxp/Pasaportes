using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Impuesto
{
    public int ImpuestoId { get; set; }

    public string? ImpuestoDescripcion { get; set; }

    public string? ImpuestoCodigo { get; set; }

    public int? ImpuestoEstado { get; set; }

    public virtual Estado? ImpuestoEstadoNavigation { get; set; }
}
