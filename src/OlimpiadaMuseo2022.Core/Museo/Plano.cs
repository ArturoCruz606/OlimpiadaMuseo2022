using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlimpiadaMuseo2022.Core.Museo
{
    public class Plano
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public CMuseo Museo { get; set; }
        public string Descripcion { get; set; }
        public Plano(int id, string nombre, CMuseo museo, string descripcion)
        {
            ID = id;
            Nombre = nombre;
            Museo = museo;
            Descripcion = descripcion;
        }
    }
}