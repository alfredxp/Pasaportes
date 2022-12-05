using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Pasaporte
{
    public int PasaporteId { get; set; }

    public string? PasaporteDescripcion { get; set; }

    public string? PasaporteCodigo { get; set; }

    public string? PasaporteNombre { get; set; }

    public string? PasaporteApellido { get; set; }

    public string? PasaporteCedula { get; set; }

    public string? PasaporteCorreo { get; set; }

    public string? PasaporteDireccion { get; set; }

    public DateTime? PasaporteFechaCreacion { get; set; }

    public int? PasaporteSolicitudId { get; set; }

    public int? PasaporteEstadoId { get; set; }

    public byte[]? PasaporteImage { get; set; }

    public virtual Estado? PasaporteEstado { get; set; }

    public virtual Solicitude? PasaporteSolicitud { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
