using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackendProF.EntityF;

public partial class Pelicula
{
    [Key]
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public DateTime Año { get; set; }

    public string Director { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string Poster { get; set; } = null!;
}
