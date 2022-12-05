using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Solicitude
{
    public int SolicitudId { get; set; }

    public string? SolicitudNombre { get; set; }

    public DateTime? SolicitudFecha { get; set; }

    public DateTime? SolicitudFechaCreacion { get; set; }

    public DateTime? SolicitudFechaModificacion { get; set; }

    public int? SolicitudEstado { get; set; }

    public virtual ICollection<LogsSolicitude> LogsSolicitudes { get; } = new List<LogsSolicitude>();

    public virtual ICollection<Pasaporte> Pasaportes { get; } = new List<Pasaporte>();

    public virtual Estado? SolicitudEstadoNavigation { get; set; }
}
