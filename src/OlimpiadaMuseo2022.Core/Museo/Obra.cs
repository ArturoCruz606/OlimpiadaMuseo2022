using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Museo
{
    public class Obra
    {
        public int ID { get; set; }
        public Artista Artista { get; set; }
        public Exposicion Exposicion { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public Obra(int id, Artista artista, Exposicion exposicion, string nombre, string tipo, string descripcion)
        {
            ID = id;
            Artista = artista;
            Exposicion = exposicion;
            Nombre = nombre;
            Tipo = tipo;
            Descripcion = descripcion;
        }
    }
}