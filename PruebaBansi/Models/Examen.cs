﻿using System.ComponentModel.DataAnnotations;
namespace PruebaBansi.Models;

public class Examen
{
    [Key]
    public int IdExamen { get; set; }
    public string? Nombre { get; set; }
    public string? Descripcion { get; set; }
}
