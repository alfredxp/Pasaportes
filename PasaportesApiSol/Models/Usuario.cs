using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string? UsuarioLogin { get; set; }

    public string? UsuarioPassword { get; set; }

    public string? UsuarioHash { get; set; }

    public string? UsuarioSalt { get; set; }

    public string? UsuarioNombre { get; set; }

    public string? UsuarioApellido { get; set; }

    public string? UsuarioCedula { get; set; }

    public string? UsuarioCorreo { get; set; }

    public string? UsuarioSexo { get; set; }

    public string? UsuarioTelefono { get; set; }

    public string? UsuarioCelular { get; set; }

    public DateTime? UsuarioFechaCreacion { get; set; }

    public int? UsuarioEstadoId { get; set; }

    public int? UsuarioRolId { get; set; }

    public int? PasaporteId { get; set; }

    public virtual Pasaporte? Pasaporte { get; set; }

    public virtual Estado? UsuarioEstado { get; set; }

    public virtual Role? UsuarioRol { get; set; }
}
