using Cliente.Domain.Entities;
using Cliente.Domain.Interfaces;
using Cliente.Infra.Data.Context;

namespace Cliente.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SqlServerContext _sqlServerContext;

        public BaseRepository(SqlServerContext sqlServerContext)
        {
            _sqlServerContext = sqlServerContext;
        }

        public void Insert(TEntity obj)
        {
            _sqlServerContext.Database.EnsureCreated();
            _sqlServerContext.Set<TEntity>().Add(obj);
            _sqlServerContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            var cliente = _sqlServerContext.Clientes.FirstOrDefault(item => item.Id == obj.Id);
            if (cliente == null)
                throw new KeyNotFoundException();

            Client updatedCliente = (Client)Convert.ChangeType(obj, typeof(TEntity));
            cliente.Name = updatedCliente.Name;
            cliente.CPF = updatedCliente.CPF;
            cliente.Sex = updatedCliente.Sex;
            cliente.Telephone = updatedCliente.Telephone;
            cliente.Email = updatedCliente.Email;
            cliente.BirthDate = updatedCliente.BirthDate;
            cliente.Observation = updatedCliente.Observation;
            _sqlServerContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var obj = Select(id);

            if (obj == null)
                throw new KeyNotFoundException();

            _sqlServerContext.Set<TEntity>().Remove(obj);
            _sqlServerContext.SaveChanges();
        }

        public IList<TEntity> GetAll() =>
            _sqlServerContext.Set<TEntity>().ToList();

        public TEntity Select(Guid id) => _sqlServerContext.Set<TEntity>().Find(id);
    }
}
