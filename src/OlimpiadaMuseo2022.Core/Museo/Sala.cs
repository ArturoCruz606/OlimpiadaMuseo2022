using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlimpiadaMuseo2022.Core.Museo
{
    public class Sala
    {
        public int ID { get; set; }
        public Museo Museo { get; set; }
        public string Nombre { get; set; }
    }
}