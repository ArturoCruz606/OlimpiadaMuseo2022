using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using OlimpiadaMuseo2022.Core.Museo;

namespace OlimpiadaMuseo2022.Core.Personas;

[Table("Artista")]

public class Artista : Persona
{
    public List<Obra> Obras { get; set; }
    public Artista(string nombre, string apellido, DateTime nacimiento)
    : base(nombre, apellido, nacimiento)
    {
        Obras = new List<Obra>();
    }
    public void AgregarObra (Obra obra) => Obras.Add(obra);
    public void BorrarObra (Obra obra) => Obras.Remove(obra);
}