using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Configurations
{
   internal class ContratoTypeConfiguration : IEntityTypeConfiguration<Contrato>
   {
      public void Configure(EntityTypeBuilder<Contrato> builder)
      {
         builder.ToTable("TB_Contratos");

         builder.HasKey(t => t.Id).HasName("PK_Contrato");

         builder.Property(p => p.Id).HasColumnName("Id_Contrato");
         builder.Property(p => p.Valor).HasColumnName("Valor");
         //builder.Property(p => p.DataEncerramento).HasColumnName("Data_Encerramento");
         //builder.Property(p => p.DataInicio).HasColumnName("Data_Inicio");
         builder.OwnsOne(p => p.Vigencia, vigencia =>
         {
            vigencia.Property(v => v.DataInicio).HasColumnName("Data_Inicio");
            vigencia.Property(v => v.DataEncerramento).HasColumnName("Data_Encerramento");
         });
      }
   }
}
