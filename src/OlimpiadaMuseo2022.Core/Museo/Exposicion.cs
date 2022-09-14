using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlimpiadaMuseo2022.Core.Museo
{
    public class Exposicion
    {
        public int ID { get; set; }
        public Sala Sala { get; set; }
        public string Nombre { get; set; }
        public List<Obra> Obras { get; set; }
        public Exposicion(int id, Sala sala, string nombre)
        {
            ID = id;
            Sala = sala;
            Nombre = nombre;
            Obras = new List<Obra>();
        }
        public void AgregarObra (Obra obra) => Obras.Add(obra);
        public void BorrarObra (Obra obra) => Obras.Remove(obra);
    }
}