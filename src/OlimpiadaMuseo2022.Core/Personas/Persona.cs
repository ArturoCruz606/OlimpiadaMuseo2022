using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlimpiadaMuseo2022.Core.Personas;

public abstract class Persona
{
    [StringLength(45)]
    public string Nombre { get; set; }

    [StringLength(45)]
    public string Apellido { get; set; }
    public DateTime Nacimiento { get; set; }

    [NotMapped]
    public byte Edad
    {
        get
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            var anios = Convert.ToByte((hoy.Year - Nacimiento.Year));

            if (hoy.Month < Nacimiento.Month)
            {
                return --anios;
            }
            else if (hoy.Month == Nacimiento.Month && hoy.Day >= Nacimiento.Day)
            {
                return anios;
            }
            else return --anios;
        }
    }
    public Persona(string nombre, string apellido, DateTime nacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        Nacimiento = nacimiento;
    }
    public Persona() { }
}