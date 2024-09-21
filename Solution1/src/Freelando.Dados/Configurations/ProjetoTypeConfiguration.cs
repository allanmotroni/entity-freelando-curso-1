using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Configurations
{
   internal class ProjetoTypeConfiguration : IEntityTypeConfiguration<Projeto>
   {
      public void Configure(EntityTypeBuilder<Projeto> builder)
      {
         builder.ToTable("TB_Projetos");

         builder.HasKey(x => x.Id).HasName("PK_Projeto");

         builder.Property(p => p.Id).HasColumnName("Id_Projeto");
         builder.Property(p => p.Descricao).HasColumnName("DS_Projeto").HasColumnType("nvarchar(200)");
         
         builder.Property(p => p.Status).HasConversion(
            fromObj => fromObj.ToString(), 
            fromDb => (StatusProjeto)Enum.Parse(typeof(StatusProjeto), fromDb));

         builder.Property(p => p.Titulo).HasColumnName("Titulo").HasColumnType("nvarchar(max)");
      }
   }
}
