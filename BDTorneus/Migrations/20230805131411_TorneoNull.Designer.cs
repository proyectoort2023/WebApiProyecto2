﻿// <auto-generated />
using System;
using BDTorneus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BDTorneus.Migrations
{
    [DbContext(typeof(TorneoContext))]
    [Migration("20230805131411_TorneoNull")]
    partial class TorneoNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BDTorneus.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capitan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Deporte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("BDTorneus.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedioPago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Monto")
                        .HasColumnType("float");

                    b.Property<string>("OrdenPagoMP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PreferenciaMP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id", "TorneoId", "EquipoId", "UsuarioId");

                    b.HasIndex("EquipoId");

                    b.HasIndex("TorneoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Inscripciones");
                });

            modelBuilder.Entity("BDTorneus.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("BDTorneus.Medalla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedallaImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreTorneo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medallas");
                });

            modelBuilder.Entity("BDTorneus.Notificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<bool>("General")
                        .HasColumnType("bit");

                    b.Property<bool>("Leido")
                        .HasColumnType("bit");

                    b.Property<string>("Mensaje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("TorneoId");

                    b.ToTable("Notificaciones");
                });

            modelBuilder.Entity("BDTorneus.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("DisparadorSiguienteFase")
                        .HasColumnType("bit");

                    b.Property<int?>("EquipoLocalId")
                        .HasColumnType("int");

                    b.Property<int?>("EquipoVisitanteId")
                        .HasColumnType("int");

                    b.Property<string>("EstadoPartido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Grupo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GuidPartido")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HistorialSet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcadorLocal")
                        .HasColumnType("int");

                    b.Property<int>("MarcadorVisitante")
                        .HasColumnType("int");

                    b.Property<string>("NombreCancha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PartidoSigGanador")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PartidoSigPerdedor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PuntajeLocal")
                        .HasColumnType("int");

                    b.Property<int>("PuntajeVisitante")
                        .HasColumnType("int");

                    b.Property<int>("Ronda")
                        .HasColumnType("int");

                    b.Property<bool>("RondaDescanso")
                        .HasColumnType("bit");

                    b.Property<string>("SeleccionEquipoDelGrupo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SetActual")
                        .HasColumnType("int");

                    b.Property<int>("SetGanadosLocal")
                        .HasColumnType("int");

                    b.Property<int>("SetGanadosVisitante")
                        .HasColumnType("int");

                    b.Property<int>("TorneoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipoLocalId");

                    b.HasIndex("EquipoVisitanteId");

                    b.HasIndex("TorneoId");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("BDTorneus.Torneo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Banner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CantidadCanchas")
                        .HasColumnType("int");

                    b.Property<bool>("Cerrrado")
                        .HasColumnType("bit");

                    b.Property<string>("ConfiguracionEquipos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HabilitacionInscripcion")
                        .HasColumnType("bit");

                    b.Property<DateTime>("HoraComienzo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Indoor")
                        .HasColumnType("bit");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxEquiposInscriptos")
                        .HasColumnType("int");

                    b.Property<int>("MaxJugadoresPorEquipo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Otros")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int>("PuntajeMax")
                        .HasColumnType("int");

                    b.Property<int>("PuntajeMaxUltimoSet")
                        .HasColumnType("int");

                    b.Property<int>("SetsMax")
                        .HasColumnType("int");

                    b.Property<bool>("Suspendido")
                        .HasColumnType("bit");

                    b.Property<string>("TelContacto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPrecio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UbicacionGPS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Torneos");
                });

            modelBuilder.Entity("BDTorneus.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccessTokenMercadopago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccessTokenRefreshMercadopago")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCaducidadTokenMercadopago")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("EquipoJugador", b =>
                {
                    b.Property<int>("EquiposId")
                        .HasColumnType("int");

                    b.Property<int>("JugadoresId")
                        .HasColumnType("int");

                    b.HasKey("EquiposId", "JugadoresId");

                    b.HasIndex("JugadoresId");

                    b.ToTable("EquipoJugador");
                });

            modelBuilder.Entity("BDTorneus.Equipo", b =>
                {
                    b.HasOne("BDTorneus.Usuario", "Usuario")
                        .WithMany("Equipos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BDTorneus.Inscripcion", b =>
                {
                    b.HasOne("BDTorneus.Equipo", "Equipo")
                        .WithMany("Inscripciones")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDTorneus.Torneo", "Torneo")
                        .WithMany("Inscripciones")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDTorneus.Usuario", "Usuario")
                        .WithMany("Inscripciones")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Torneo");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BDTorneus.Notificacion", b =>
                {
                    b.HasOne("BDTorneus.Equipo", "Equipo")
                        .WithMany()
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDTorneus.Torneo", "Torneo")
                        .WithMany()
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("BDTorneus.Partido", b =>
                {
                    b.HasOne("BDTorneus.Equipo", "EquipoLocal")
                        .WithMany()
                        .HasForeignKey("EquipoLocalId");

                    b.HasOne("BDTorneus.Equipo", "EquipoVisitante")
                        .WithMany()
                        .HasForeignKey("EquipoVisitanteId");

                    b.HasOne("BDTorneus.Torneo", "Torneo")
                        .WithMany("Fixture")
                        .HasForeignKey("TorneoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipoLocal");

                    b.Navigation("EquipoVisitante");

                    b.Navigation("Torneo");
                });

            modelBuilder.Entity("BDTorneus.Torneo", b =>
                {
                    b.HasOne("BDTorneus.Usuario", "Usuario")
                        .WithMany("Torneos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EquipoJugador", b =>
                {
                    b.HasOne("BDTorneus.Equipo", null)
                        .WithMany()
                        .HasForeignKey("EquiposId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BDTorneus.Jugador", null)
                        .WithMany()
                        .HasForeignKey("JugadoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BDTorneus.Equipo", b =>
                {
                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("BDTorneus.Torneo", b =>
                {
                    b.Navigation("Fixture");

                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("BDTorneus.Usuario", b =>
                {
                    b.Navigation("Equipos");

                    b.Navigation("Inscripciones");

                    b.Navigation("Torneos");
                });
#pragma warning restore 612, 618
        }
    }
}
