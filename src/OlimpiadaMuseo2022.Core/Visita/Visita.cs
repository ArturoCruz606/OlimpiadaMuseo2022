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
        public CMuseo Museo { get; set; }
        public Persona Guia { get; set; }
        public List<Persona> Visitantes { get; set; }
        public List<Sala> Salas { get; set; }
        public DateTime FechaHora { get; set; }
        public Visita (int id, CMuseo museo, Persona guia, DateTime fechahora){
            ID = id;
            Museo = museo;
            Guia = guia;
            FechaHora = fechahora;
            Visitantes = new List<Persona>();
            Salas = new List<Sala>();
        }
        public void AgregaVisitante (Persona visitante) => Visitantes.Add(visitante);
        public void BorrarVisitante (Persona visitante) => Visitantes.Remove(visitante);
        public void AgregarSala (Sala sala) => Salas.Add(sala);
        public void BorrarSala (Sala sala) => Salas.Remove(sala);
    }
}