using System;
using System.Collections.Generic;

namespace APIExamen.Models;

public partial class Tienda
{
    public int IdTTienda { get; set; }

    public string NombreTienda { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public bool Estado { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string UsuarioCreacion { get; set; } = null!;
}
