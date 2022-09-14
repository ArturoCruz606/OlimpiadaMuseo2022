using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OlimpiadaMuseo2022.Core.Personas;

namespace OlimpiadaMuseo2022.Core;

public class Contexto : DbContext
{
    DbSet<Visitante> Visitantes { get; set; }
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