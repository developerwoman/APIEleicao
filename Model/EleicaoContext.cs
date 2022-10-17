using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIEleicao.Model
{
    public class EleicaoContext : DbContext
    {
        //public EleicaoContext() { } 

        public EleicaoContext(DbContextOptions<EleicaoContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Candidato> Candidatos { get; set; }
        //public DbSet<Voto> Votos { get; set; }
        


        private void ConfigCandidato(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidato>(x =>
            {
                x.ToTable("Candidato");
                x.HasKey(c => c.Id_candidato);
                x.Property(c => c.Id_candidato).ValueGeneratedOnAdd().UseIdentityColumn();
                x.Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(200);
                x.Property(c => c.Vice).HasColumnName("VICE").HasMaxLength(200);
                x.Property(c => c.Codigo).HasColumnName("CODIGO").HasMaxLength(2);
                x.Property(c => c.Legenda).HasColumnName("LEGENDA").HasMaxLength(100);
                x.Property(c => c.Data_registro).HasColumnName("DATA_REGISTRO").ValueGeneratedOnAdd();
            });
        }

        //private void ConfigVoto(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Voto>(etd =>
        //    {
        //        etd.ToTable("Voto");
        //        etd.HasNoKey();
        //        etd.Property(p => p.Id_candidato).HasColumnName("ID_CANDIDATO").HasMaxLength(200);
        //        etd.Property(p => p.Data_registro).HasColumnName("DATA_REGISTRO").ValueGeneratedOnAdd();
        //        //etd.HasOne(c => c.Candidato).WithMany(p => p.Votos);

        //    });
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseIdentityColumns();
            modelBuilder.HasDefaultSchema("ESTUDOS");

            ConfigCandidato(modelBuilder);
            //ConfigVoto(modelBuilder);
        }
    }
}

//Erro: Services for database providers 'Microsoft.EntityFrameworkCore.Sqlite', 'Microsoft.EntityFrameworkCore.SqlServer' have been registered in the service provider.Only a single database provider can be registered in a service provider.If possible, ensure that Entity Framework is managing its service provider by removing the call to 'UseInternalServiceProvider'.Otherwise, consider conditionally registering the database provider, or maintaining one service provider per database provider.