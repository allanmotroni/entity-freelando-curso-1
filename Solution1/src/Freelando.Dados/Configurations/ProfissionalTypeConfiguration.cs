using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Configurations
{
   internal class ProfissionalTypeConfiguration : IEntityTypeConfiguration<Profissional>
   {
      public void Configure(EntityTypeBuilder<Profissional> builder)
      {
         builder.ToTable("TB_Profissionais");

         builder.HasKey(x => x.Id)
            .HasName("PK_Profissional");

         builder.Property(p => p.Id)
            .HasColumnName("Id_Profissional")
            .IsRequired();

         builder.Property(p => p.Nome)
            .HasColumnName("Nome")
            .HasColumnType("nvarchar(max)")
            .IsRequired(false);
         builder.Property(p => p.Cpf)
            .HasColumnName("Cpf")
            .HasColumnType("nvarchar(max)")
            .IsRequired(false);
         builder.Property(p => p.Email)
            .HasColumnName("Email")
            .HasColumnType("nvarchar(max)")
            .IsRequired(false);
         builder.Property(p => p.Telefone)
            .HasColumnName("Telefone")
            .HasColumnType("nvarchar(max)")
            .IsRequired(false);

      }
   }
}
