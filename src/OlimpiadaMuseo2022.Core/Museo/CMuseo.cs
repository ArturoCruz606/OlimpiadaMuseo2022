using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Museo
{
    public class CMuseo
    {
        public int ID { get; set; }
        public List<Plano> Planos { get; set; }
        public Persona Fundador { get; set; }
        public string Nombre { get; set; }
        public DateOnly Fundacion { get; set; }
        public string Direccion { get; set; }
        public List<Sala> Salas { get; set; }
        public CMuseo (int id, Persona fundador, string nombre, DateOnly fundacion, string direccion) {
            ID = id;
            Fundador = fundador;
            Nombre = nombre;
            Fundacion = fundacion;
            Direccion = direccion;
            Planos = new List<Plano>();
            Salas = new List<Sala>();
        }
        public void AgregarPlano (Plano plano) => Planos.Add(plano);
        public void BorrarPlano (Plano plano) => Planos.Remove(plano);
        public void AgregarSala (Sala sala) => Salas.Add(sala);
        public void BorrarSala (Sala sala) => Salas.Remove(sala);
    } 
}