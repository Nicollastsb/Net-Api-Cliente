using Cliente.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Cliente.Infra.Data.Context
{
    public class UserMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .HasConversion(prop => prop.ToString(), prop => prop)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.CPF)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("CPF")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Sex)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Sex")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Telephone)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Telephone")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .IsRequired()
               .HasColumnName("Email")
               .HasColumnType("varchar(100)");

            builder.Property(prop => prop.BirthDate)
               .IsRequired()
               .HasColumnName("BirthDate")
               .HasColumnType("datetime");

            builder.Property(prop => prop.Observation)
               .HasConversion(prop => prop.ToString(), prop => prop)
               .HasColumnName("Observation")
               .HasColumnType("varchar(100)");
        }
    }
}
