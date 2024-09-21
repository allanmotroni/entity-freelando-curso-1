using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Configurations
{
   internal class CandidaturaTypeConfiguration : IEntityTypeConfiguration<Candidatura>
   {
      public void Configure(EntityTypeBuilder<Candidatura> builder)
      {
         builder.ToTable("TB_Candidaturas");

         builder.HasKey(p => p.Id).HasName("PK_Candidatura");

         builder.Property(p => p.Id).HasColumnName("Id_Candidatura");
         builder.Property(p => p.DescricaoProposta).HasColumnName("DS_Proposta").HasColumnType("nvarchar(max)");
         builder.Property(p => p.ValorProposto).HasColumnName("Valor_Proposto");
         
         builder.Property(p => p.DuracaoProposta).HasColumnName("Duracao_Proposta").HasConversion(
            fromObj => fromObj.ToString(),
            fromDb => (DuracaoEmDias)Enum.Parse(typeof(DuracaoEmDias), fromDb));
         
         builder.Property(p => p.Status).HasConversion(
            fromObj => fromObj.ToString(),
            fromDb => (StatusCandidatura)Enum.Parse(typeof(StatusCandidatura), fromDb));

      }
   }
}
