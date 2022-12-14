// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OlimpiadaMuseo2022.Core;

#nullable disable

namespace OlimpiadaMuseo2022.Core.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.CMuseo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<DateOnly>("Fundacion")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("ID");

                    b.ToTable("Museo");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Exposicion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdSala")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("ID");

                    b.HasIndex("IdSala");

                    b.ToTable("Exposicion");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Obra", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<int>("IdArtista")
                        .HasColumnType("int");

                    b.Property<int>("IdExposicion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("ID");

                    b.HasIndex("IdArtista");

                    b.HasIndex("IdExposicion");

                    b.ToTable("Obra");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Plano", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int>("IdMuseo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("ID");

                    b.HasIndex("IdMuseo");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Sala", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CVisitaID")
                        .HasColumnType("int");

                    b.Property<int>("IdMuseo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("ID");

                    b.HasIndex("CVisitaID");

                    b.HasIndex("IdMuseo");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Personas.Artista", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("ID");

                    b.ToTable("Artista");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Personas.Visitante", b =>
                {
                    b.Property<int>("DNI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.Property<int?>("CVisitaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("varchar(45)");

                    b.HasKey("DNI");

                    b.HasIndex("CVisitaID");

                    b.ToTable("Visitante");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Visita.CVisita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdGuia")
                        .HasColumnType("int");

                    b.Property<int>("IdMuseo")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdGuia");

                    b.HasIndex("IdMuseo");

                    b.ToTable("Visita");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Visita.Turno", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdVisita")
                        .HasColumnType("int");

                    b.Property<int>("IdVisitante")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdVisita");

                    b.HasIndex("IdVisitante");

                    b.ToTable("Turno");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Exposicion", b =>
                {
                    b.HasOne("OlimpiadaMuseo2022.Core.Museo.Sala", "Sala")
                        .WithMany("Exposiciones")
                        .HasForeignKey("IdSala")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Obra", b =>
                {
                    b.HasOne("OlimpiadaMuseo2022.Core.Personas.Artista", "Artista")
                        .WithMany("Obras")
                        .HasForeignKey("IdArtista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlimpiadaMuseo2022.Core.Museo.Exposicion", "Exposicion")
                        .WithMany("Obras")
                        .HasForeignKey("IdExposicion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");

                    b.Navigation("Exposicion");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Plano", b =>
                {
                    b.HasOne("OlimpiadaMuseo2022.Core.Museo.CMuseo", "Museo")
                        .WithMany("Planos")
                        .HasForeignKey("IdMuseo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Museo");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Sala", b =>
                {
                    b.HasOne("OlimpiadaMuseo2022.Core.Visita.CVisita", null)
                        .WithMany("Salas")
                        .HasForeignKey("CVisitaID");

                    b.HasOne("OlimpiadaMuseo2022.Core.Museo.CMuseo", "Museo")
                        .WithMany("Salas")
                        .HasForeignKey("IdMuseo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Museo");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Personas.Visitante", b =>
                {
                    b.HasOne("OlimpiadaMuseo2022.Core.Visita.CVisita", null)
                        .WithMany("Visitantes")
                        .HasForeignKey("CVisitaID");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Visita.CVisita", b =>
                {
                    b.HasOne("OlimpiadaMuseo2022.Core.Personas.Visitante", "Guia")
                        .WithMany()
                        .HasForeignKey("IdGuia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlimpiadaMuseo2022.Core.Museo.CMuseo", "Museo")
                        .WithMany()
                        .HasForeignKey("IdMuseo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guia");

                    b.Navigation("Museo");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Visita.Turno", b =>
                {
                    b.HasOne("OlimpiadaMuseo2022.Core.Visita.CVisita", "Visita")
                        .WithMany()
                        .HasForeignKey("IdVisita")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OlimpiadaMuseo2022.Core.Personas.Visitante", "Visitante")
                        .WithMany()
                        .HasForeignKey("IdVisitante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visita");

                    b.Navigation("Visitante");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.CMuseo", b =>
                {
                    b.Navigation("Planos");

                    b.Navigation("Salas");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Exposicion", b =>
                {
                    b.Navigation("Obras");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Museo.Sala", b =>
                {
                    b.Navigation("Exposiciones");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Personas.Artista", b =>
                {
                    b.Navigation("Obras");
                });

            modelBuilder.Entity("OlimpiadaMuseo2022.Core.Visita.CVisita", b =>
                {
                    b.Navigation("Salas");

                    b.Navigation("Visitantes");
                });
#pragma warning restore 612, 618
        }
    }
}
