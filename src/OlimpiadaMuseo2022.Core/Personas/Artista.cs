using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlimpiadaMuseo2022.Core.Museo;

namespace OlimpiadaMuseo2022.Core.Personas
{
    public class Artista : Persona 
    {
        public List<Obra> Obras { get; set; }
    }
}