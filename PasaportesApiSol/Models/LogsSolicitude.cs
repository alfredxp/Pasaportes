using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class LogsSolicitude
{
    public int LogId { get; set; }

    public string? LogDescripcion { get; set; }

    public DateTime? LogFecha { get; set; }

    public int? LogSolicitudesId { get; set; }

    public virtual Solicitude? LogSolicitudes { get; set; }
}
