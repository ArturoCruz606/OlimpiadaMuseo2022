using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlimpiadaMuseo2022.Core.Museo;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Visita
{
    public class Turno
    {
        public int ID { get; set; }
        public Visitante Guia { get; set; }
        public Visitante Visitante { get; set; }
        public DateTime FechaHora { get; set; }
        public Turno(int id, Visitante guia, Visitante visitante, DateTime fechahora)
        {
            ID = id;
            Guia = guia;
            Visitante = visitante;
            FechaHora = fechahora;
        }
    }
}