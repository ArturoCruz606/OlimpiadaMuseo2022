using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OlimpiadaMuseo2022.Core.Museo;

namespace OlimpiadaMuseo2022.Core.Personas;

[Table("Artista")]

public class Artista : Persona
{
    [Key]
    public int ID { get; set; }
    public List<Obra> Obras { get; set; }
    public void AgregarObra (Obra obra) => Obras.Add(obra);
    public void BorrarObra (Obra obra) => Obras.Remove(obra);
    public Artista(int id, string nombre, string apellido, DateTime nacimiento)
    : base(nombre, apellido, nacimiento)
    {
        ID = id;
        Obras = new List<Obra>();
    }
    public Artista() { }
}