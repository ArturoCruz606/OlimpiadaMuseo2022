using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Museo
{
    public class Museo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public Fundador Fundador { get; set; }
        public DateOnly Fundacion { get; set; }
        public string Direccion { get; set; }
    }
}