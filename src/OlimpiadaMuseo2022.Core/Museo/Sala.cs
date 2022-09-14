using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlimpiadaMuseo2022.Core.Museo;

[Table("Exposicion")]

public class Sala
{
    [Key]
    public int ID { get; set; }

    [NotMapped]
    public CMuseo Museo { get; set; }

    [StringLength(45)]
    public string Nombre { get; set; }
    public List<Exposicion> Exposiciones { get; set; }
    public Sala(int id, CMuseo museo, string nombre)
    {
        ID = id;
        Museo = museo;
        Nombre = nombre;
        Exposiciones = new List<Exposicion>();
    }
    public Sala() { }
    public void AgregarExposicion (Exposicion exposicion) => Exposiciones.Add(exposicion);
    public void BorrarExposicion (Exposicion exposicion) => Exposiciones.Remove(exposicion);
}