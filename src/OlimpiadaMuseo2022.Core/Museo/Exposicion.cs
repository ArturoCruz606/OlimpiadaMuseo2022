using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlimpiadaMuseo2022.Core.Museo;

[Table("Exposicion")]
public class Exposicion
{
    [Key]
    public int ID { get; set; }
    public int IdSala { get; set; }
    [ForeignKey("IdSala")]
    public Sala Sala { get; set; }

    [StringLength(45)]
    public string Nombre { get; set; }
    public List<Obra> Obras { get; set; }
    public Exposicion(int id, Sala sala, string nombre)
    {
        ID = id;
        Sala = sala;
        Nombre = nombre;
        Obras = new List<Obra>();
    }
    public Exposicion() { }
    public void AgregarObra (Obra obra) => Obras.Add(obra);
    public void BorrarObra (Obra obra) => Obras.Remove(obra);
}