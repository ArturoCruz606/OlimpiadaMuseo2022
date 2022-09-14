using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OlimpiadaMuseo2022.Core.Museo;
[Table("Plano")]
public class Plano
{
    [Key]
    public int ID { get; set; }

    [StringLength(45)]
    public string Nombre { get; set; }
    public int IdMuseo { get; set; }
    
    [ForeignKey("IdMuseo")]
    public CMuseo Museo { get; set; }

    [StringLength(45)]
    public string Descripcion { get; set; }
    public Plano(int id, string nombre, CMuseo museo, string descripcion)
    {
        ID = id;
        Nombre = nombre;
        Museo = museo;
        Descripcion = descripcion;
    }
    public Plano() { }
}