using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlimpiadaMuseo2022.Core.Museo;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Visita
{
    public class Visita
    {
        public int ID { get; set; }
        public Guia Guia { get; set; }
        public List<Visitante> Visitantes { get; set; }
        public List<Sala> Salas { get; set; }
        public DateTime FechaHora { get; set; }
    }
}