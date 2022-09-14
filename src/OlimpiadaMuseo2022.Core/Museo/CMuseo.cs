using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Museo;

[Table("Museo")]
public class CMuseo
{
    [Key]
    public int ID { get; set; }
    public List<Plano> Planos { get; set; }

    [StringLength(45)]
    public string Nombre { get; set; }
    public DateOnly Fundacion { get; set; }

    [StringLength(45)]
    public string Direccion { get; set; }
    public List<Sala> Salas { get; set; }
    public CMuseo (int id, string nombre, DateOnly fundacion, string direccion) {
        ID = id;
        Nombre = nombre;
        Fundacion = fundacion;
        Direccion = direccion;
        Planos = new List<Plano>();
        Salas = new List<Sala>();
    }
    public CMuseo() { }
    public void AgregarPlano (Plano plano) => Planos.Add(plano);
    public void BorrarPlano (Plano plano) => Planos.Remove(plano);
    public void AgregarSala (Sala sala) => Salas.Add(sala);
    public void BorrarSala (Sala sala) => Salas.Remove(sala);
} 
