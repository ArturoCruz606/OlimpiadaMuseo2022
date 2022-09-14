using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OlimpiadaMuseo2022.Core.Museo;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Visita;
[Table("Visita")]
public class Visita
{
    [Key]
    public int ID { get; set; }
    public int IdMuseo { get; set; }

    [ForeignKey("IdMuseo")]
    public CMuseo Museo { get; set; }
    public int IdGuia { get; set; }

    [ForeignKey("IdGuia")]
    public Visitante Guia { get; set; }
    public List<Visitante> Visitantes { get; set; }
    public List<Sala> Salas { get; set; }
    public DateTime FechaHora { get; set; }
    public Visita (int id, CMuseo museo, Visitante guia, DateTime fechahora){
        ID = id;
        Museo = museo;
        Guia = guia;
        FechaHora = fechahora;
        Visitantes = new List<Visitante>();
        Salas = new List<Sala>();
    }
    public Visita() { }
    public void AgregaVisitante (Visitante visitante) => Visitantes.Add(visitante);
    public void BorrarVisitante (Visitante visitante) => Visitantes.Remove(visitante);
    public void AgregarSala (Sala sala) => Salas.Add(sala);
    public void BorrarSala (Sala sala) => Salas.Remove(sala);
}