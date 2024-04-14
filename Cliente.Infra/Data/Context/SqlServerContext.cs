using Cliente.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cliente.Infra.Data.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {

        }

        public DbSet<Client> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(x => x.Id);

            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = new Guid("7e5bdf14-3489-4cfd-bfad-16ab05a8e57c"),
                    Name = "Nicollas",
                    CPF = "00011122233",
                    Sex = "Masculino",
                    Telephone = "999998888",
                    Email = "nicollas@teste",
                    BirthDate = new DateTime(1993, 01, 09),
                    Observation = "observação teste",
                },
                new Client
                {
                    Id = new Guid("f2d932ff-2d45-48b0-86b8-a0fa4621c555"),
                    Name = "Natalia",
                    CPF = "11111122233",
                    Sex = "Feminino",
                    Telephone = "999998888",
                    Email = "natalia@teste",
                    BirthDate = new DateTime(1993, 01, 09),
                    Observation = "observação teste",
                },
                new Client
                {
                    Id = new Guid("9ebf8d85-532c-4152-87b7-2e8049e521ca"),
                    Name = "Bento",
                    CPF = "22211122233",
                    Sex = "Masculino",
                    Telephone = "999998888",
                    Email = "bento@teste",
                    BirthDate = new DateTime(1993, 01, 09),
                    Observation = "observação teste",
                },
                new Client
                {
                    Id = new Guid("6b35c42b-89f6-4a76-b2f6-68aaf9231527"),
                    Name = "Cecilia",
                    CPF = "33311122233",
                    Sex = "Feminino",
                    Telephone = "999998888",
                    Email = "cecilia@teste",
                    BirthDate = new DateTime(1993, 01, 09),
                    Observation = "observação teste",
                },
                new Client
                {
                    Id = new Guid("ff1f357d-0175-4e01-8394-154037b28db0"),
                    Name = "Jose",
                    CPF = "44411122233",
                    Sex = "Masculino",
                    Telephone = "999998888",
                    Email = "jose@teste",
                    BirthDate = new DateTime(1993, 01, 09),
                    Observation = "observação teste",
                }
            );
        }
    }
}
