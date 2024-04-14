using Cliente.Domain.Entities;

namespace Cliente.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Delete(Guid id);

        IList<TEntity> GetAll();

        TEntity Select(Guid id);
    }
}
