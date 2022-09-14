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
    }
}