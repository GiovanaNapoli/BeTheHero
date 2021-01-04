using System.Collections.Generic;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Ong> Ongs { get; set; }
        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Ong>()
                .HasData(new List<Ong>(){
                    new Ong(1, "APAE", "contato.apae.com.br", "13987653498", "Mongaguá", "SP"),
                    new Ong(2, "Estrela da Mama", "contato.estrelamama.com.br", "13987653498", "Praia Grande", "SP"),
                    new Ong(3, "Vida Por Vidas", "contato.vadaporvidas.com.br", "13987653498", "São Vicente", "SP"),
                    new Ong(4, "Pró Mangue", "contato.mangue.com.br", "13987653498", "Itanhaém", "SP"),
                    new Ong(5, "Viva Bicho Santos", "contato.vivabicho.com.br", "13987653498", "Santos", "SP"),
                                
                });
            
            builder.Entity<Incident>()
                .HasData(new List<Incident>{
                    new Incident(1, "Compra de cadeira de rodas", "Arrecadação de fundos para a compra de cadeiras de rodas para crianças necessitadas", 12.000, 1),
                    new Incident(2, "Compra de perucas", "Arrecadação de fundos para a compra de perucas para mulheres que estão passando pela quimioterapia", 12.000, 2),
                    new Incident(3, "Compra de cestas basicas", "Arrecadação de fundos para a compra de cestas basicas", 12.000, 3),
                    new Incident(4, "Compra de de equipamento", "Arrecadação de fundos para a compra de equipamentos para revitalização dos mangues", 12.000, 4),
                    new Incident(5, "Compra de ração", "Arrecadação de fundos para a compra de ração", 12.000, 5),

                });
            
        }
    }
}