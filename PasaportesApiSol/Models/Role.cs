using System;
using System.Collections.Generic;

namespace PasaportesApiSol.Models;

public partial class Role
{
    public int RolId { get; set; }

    public string? RolNombre { get; set; }

    public string? RolDescripcion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
