using Cliente.Domain.Entities;
using Cliente.Domain.Interfaces;
using Cliente.Service;
using Cliente.Service.Validators;

namespace Test_Api_Cliente
{
    public class BaseServiceTest
    {
        BaseService<Client> _baseService;
        IBaseRepository<Client> _baseRepository;

        public BaseServiceTest()
        {
            _baseRepository = new BaseRepositoryFake<Client>();
            _baseService = new BaseService<Client>(_baseRepository);
        }

        [Fact]
        public void Add_ClienteSuccess()
        {
            var cliente = new Client
            {
                Name = "Nicollas",
                CPF = "00011122233",
                Sex = "Masculino",
                Telephone = "999998888",
                Email = "nicollas@teste",
                BirthDate = new DateTime(1993, 01, 09),
                Observation = "observação teste",
            };

            // Act
            var result = _baseService.Add<ClienteValidator>(cliente);
            // Assert
            Assert.IsType<Client>(result);
        }


        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]
                {
                    new Client
                    {
                        Id = Guid.NewGuid(),
                        Name = "",
                        CPF = "00011122233",
                        Sex = "Masculino",
                        Telephone = "999998888",
                        Email = "nicollas@teste",
                        BirthDate = new DateTime(1993, 01, 09),
                        Observation = "observação teste",
                    }
                },
                new object[]
                {
                    new Client
                    {
                        Id = Guid.NewGuid(),
                        Name = "Natalia",
                        CPF = "",
                        Sex = "Feminino",
                        Telephone = "999998888",
                        Email = "natalia@teste",
                        BirthDate = new DateTime(1993, 01, 09),
                        Observation = "observação teste",
                    }
                },
                new object[]
                {
                    new Client
                    {
                        Id = Guid.NewGuid(),
                        Name = "Bento",
                        CPF = "22211122233",
                        Sex = "",
                        Telephone = "999998888",
                        Email = "bento@teste",
                        BirthDate = new DateTime(1993, 01, 09),
                        Observation = "observação teste",
                    }
                },
                new object[]
                {
                    new Client
                    {
                        Id = Guid.NewGuid(),
                        Name = "Cecilia",
                        CPF = "33311122233",
                        Sex = "Feminino",
                        Telephone = "",
                        Email = "cecilia@teste",
                        BirthDate = new DateTime(1993, 01, 09),
                        Observation = "observação teste",
                    }
                },
                new object[]
                {
                    new Client
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jose",
                        CPF = "44411122233",
                        Sex = "Masculino",
                        Telephone = "999998888",
                        Email = "",
                        BirthDate = new DateTime(1993, 01, 09),
                        Observation = "observação teste",
                    }
                },
                new object[]
                {
                    new Client
                    {
                        Id = Guid.NewGuid(),
                        Name = "Jose",
                        CPF = "44411122233",
                        Sex = "Masculino",
                        Telephone = "999998888",
                        Email = "",
                        BirthDate = new DateTime(2030, 01, 09),
                        Observation = "observação teste",
                    }
                }
            };

        [Theory, MemberData(nameof(Data))]
        public void Add_Invalid_Cliente(Client newCliente)
        {
            // Assert
            Assert.Throws<FluentValidation.ValidationException>(() => _baseService.Add<ClienteValidator>(newCliente));
        }

        [Fact]
        public void Delete_Cliente_Not_Found()
        {
            Assert.Throws<KeyNotFoundException>(() => _baseService.Delete(new Guid("7e5bdf14-3489-4cfd-bfad-16ab05a8e57D")));
        }

        [Fact]
        public void Update_Cliente_Not_Found()
        {
            Assert.Throws<KeyNotFoundException>(() => _baseService.Delete(new Guid("7e5bdf14-3489-4cfd-bfad-16ab05a8e22D")));
        }
    }
}
