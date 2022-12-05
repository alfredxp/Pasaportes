using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Oficina
{
    public int OficinaId { get; set; }

    public string? OficinaNombre { get; set; }

    public string? OficinaTelefono { get; set; }

    public string? OficinaDireccion { get; set; }

    public int? OficinaEstado { get; set; }

    public virtual Estado? OficinaEstadoNavigation { get; set; }
}
