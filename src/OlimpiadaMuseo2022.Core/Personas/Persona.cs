using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlimpiadaMuseo2022.Core.Personas
{
    public abstract class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
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
    }
}
