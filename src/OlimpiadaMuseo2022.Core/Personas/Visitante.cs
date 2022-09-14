using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlimpiadaMuseo2022.Core.Personas;

[Table("Visitante")]
public class Visitante : Persona
{
    public Visitante(int dni, string nombre, string apellido, DateTime nacimiento)
        : base(dni, nombre, apellido, nacimiento)
            => ID = dni;
    public Visitante() { }
}
