using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Configurations
{
   internal class ServicoTypeConfiguration : IEntityTypeConfiguration<Servico>
   {
      public void Configure(EntityTypeBuilder<Servico> builder)
      {
         builder.ToTable("TB_Servicos");

         builder.HasKey(p => p.Id)
            .HasName("PK_Servico");

         builder.Property(p => p.Id)
            .HasColumnName("ID_Servico");
         builder.Property(p => p.Descricao)
            .HasColumnName("DS_Projeto")
            .HasColumnType("nvarchar(max)");
         builder.Property(p => p.Titulo)
            .HasColumnName("Titulo")
            .HasColumnType("nvarchar(max)");
         builder.Property(p => p.Status)
            .HasColumnType("nvarchar(max)")
            .HasConversion(
            fromObj => fromObj.ToString(),
            fromDb => (StatusServico)Enum.Parse(typeof(StatusServico), fromDb));
      }
   }
}
