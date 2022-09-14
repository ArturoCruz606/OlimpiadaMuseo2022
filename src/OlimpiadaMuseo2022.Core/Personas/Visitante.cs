using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlimpiadaMuseo2022.Core.Personas;

[Table("Visitante")]
public class Visitante: Persona
{
    [Key]
    public int DNI { get; set; }
    public Visitante(int dni, string nombre, string apellido, DateTime nacimiento)
    : base(nombre, apellido, nacimiento)
    {
        DNI = dni;
    }
    public Visitante() { }
}
