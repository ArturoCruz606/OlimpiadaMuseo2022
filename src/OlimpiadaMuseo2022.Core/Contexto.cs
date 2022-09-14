using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OlimpiadaMuseo2022.Core.Museo;
using OlimpiadaMuseo2022.Core.Personas;
using OlimpiadaMuseo2022.Core.Visita;

namespace OlimpiadaMuseo2022.Core;

public class Contexto : DbContext
{
    DbSet<Visitante> Visitantes { get; set; }
    DbSet<Artista> Artistas { get; set; }
    DbSet<Turno> Turnos { get; set; }
    DbSet<CVisita> Visitas { get; set; }
    DbSet<CMuseo> Museos { get; set; }
    DbSet<Sala> Salas { get; set; }
    DbSet<Exposicion> Exposiciones { get; set; }
    DbSet<Obra> Obras { get; set; }
    DbSet<Plano> Planos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder ob)
    {
        if (!ob.IsConfigured)
        {
            IConfiguration myConfig = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appSettings.json")
                .Build();

            string strConexion = myConfig.GetConnectionString("dev");
            var serverVersion = new MySqlServerVersion(versionString: myConfig["SerVersion"]);
            ob.UseMySql(strConexion, serverVersion);
        }
    }
}