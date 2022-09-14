using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core.Visita;
[Table("Turno")]
public class Turno
{
    [Key]
    public int ID { get; set; }
    public int IdVisita { get; set; }

    [ForeignKey("IdVisita")]
    public Visita Visita { get; set; }

    public int IdVisitante { get; set; }

    [ForeignKey("IdVisitante")]
    public Visitante Visitante { get; set; }
    public DateTime FechaHora { get; set; }
    public Turno(int id, Visita visita, Visitante visitante, DateTime fechahora)
    {
        ID = id;
        Visita = visita;
        Visitante = visitante;
        FechaHora = fechahora;
    }
    public Turno() { }
}