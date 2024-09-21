using Freelando.Modelo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Freelando.Dados.Configurations
{
   internal class ClienteTypeConfiguration : IEntityTypeConfiguration<Cliente>
   {
      public void Configure(EntityTypeBuilder<Cliente> builder)
      {
         builder.ToTable("TB_Clientes");

         builder.HasKey(p => p.Id)
            .HasName("PK_Cliente");

         builder.Property(p => p.Id)
            .HasColumnName("Id_Cliente");
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
