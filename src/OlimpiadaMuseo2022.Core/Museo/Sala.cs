using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlimpiadaMuseo2022.Core.Museo
{
    public class Sala
    {
        public int ID { get; set; }
        public CMuseo Museo { get; set; }
        public string Nombre { get; set; }
        public List<Exposicion> Exposiciones { get; set; }
        public Sala(int id, CMuseo museo, string nombre)
        {
            ID = id;
            Museo = museo;
            Nombre = nombre;
            Exposiciones = new List<Exposicion>();
        }
        public void AgregarExposicion (Exposicion exposicion) => Exposiciones.Add(exposicion);
        public void BorrarExposicion (Exposicion exposicion) => Exposiciones.Remove(exposicion);
    }
}