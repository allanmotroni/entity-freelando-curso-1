using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Configurations
{
   internal class EspecialidadeTypeConfiguration : IEntityTypeConfiguration<Especialidade>
   {
      public void Configure(EntityTypeBuilder<Especialidade> builder)
      {
         builder.ToTable("TB_Especialidades");

         builder.Property(p => p.Id).HasColumnName("ID_Especialidade");
         builder.Property(p => p.Descricao).HasColumnName("DS_Especialidade");
      }
   }
}
