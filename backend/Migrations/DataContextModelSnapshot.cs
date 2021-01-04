﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

namespace backend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("backend.Models.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("OngId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("OngId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Arrecadação de fundos para a compra de cadeiras de rodas para crianças necessitadas",
                            OngId = 1,
                            Title = "Compra de cadeira de rodas",
                            Value = 12.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Arrecadação de fundos para a compra de perucas para mulheres que estão passando pela quimioterapia",
                            OngId = 2,
                            Title = "Compra de perucas",
                            Value = 12.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Arrecadação de fundos para a compra de cestas basicas",
                            OngId = 3,
                            Title = "Compra de cestas basicas",
                            Value = 12.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "Arrecadação de fundos para a compra de equipamentos para revitalização dos mangues",
                            OngId = 4,
                            Title = "Compra de de equipamento",
                            Value = 12.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "Arrecadação de fundos para a compra de ração",
                            OngId = 5,
                            Title = "Compra de ração",
                            Value = 12.0
                        });
                });

            modelBuilder.Entity("backend.Models.Ong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Whatsapp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ongs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Mongaguá",
                            Email = "contato.apae.com.br",
                            Name = "APAE",
                            Uf = "SP",
                            Whatsapp = "13987653498"
                        },
                        new
                        {
                            Id = 2,
                            City = "Praia Grande",
                            Email = "contato.estrelamama.com.br",
                            Name = "Estrela da Mama",
                            Uf = "SP",
                            Whatsapp = "13987653498"
                        },
                        new
                        {
                            Id = 3,
                            City = "São Vicente",
                            Email = "contato.vadaporvidas.com.br",
                            Name = "Vida Por Vidas",
                            Uf = "SP",
                            Whatsapp = "13987653498"
                        },
                        new
                        {
                            Id = 4,
                            City = "Itanhaém",
                            Email = "contato.mangue.com.br",
                            Name = "Pró Mangue",
                            Uf = "SP",
                            Whatsapp = "13987653498"
                        },
                        new
                        {
                            Id = 5,
                            City = "Santos",
                            Email = "contato.vivabicho.com.br",
                            Name = "Viva Bicho Santos",
                            Uf = "SP",
                            Whatsapp = "13987653498"
                        });
                });

            modelBuilder.Entity("backend.Models.Incident", b =>
                {
                    b.HasOne("backend.Models.Ong", "Ong")
                        .WithMany()
                        .HasForeignKey("OngId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ong");
                });
#pragma warning restore 612, 618
        }
    }
}
