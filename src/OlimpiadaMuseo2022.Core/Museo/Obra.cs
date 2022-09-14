using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Museo;

[Table("Obra")]

public class Obra
{
    [Key]
    public int ID { get; set; }

    public int IdArtista { get; set; }

    [ForeignKey("IdArtista")]
    public Artista Artista { get; set; }
    public int IdExposicion { get; set; }
    
    [ForeignKey("IdExposicion")]
    public Exposicion Exposicion { get; set; }

    [StringLength(45)]
    public string Nombre { get; set; }

    [StringLength(45)]
    public string Tipo { get; set; }

    [StringLength(80)]
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
    public Obra() { }
}