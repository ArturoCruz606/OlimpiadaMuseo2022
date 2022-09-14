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
        public Persona Guia { get; set; }
        public Persona Visitante { get; set; }
        public DateTime FechaHora { get; set; }
        public Turno(int id, Persona guia, Persona visitante, DateTime fechahora)
        {
            ID = id;
            Guia = guia;
            Visitante = visitante;
            FechaHora = fechahora;
        }
    }
}