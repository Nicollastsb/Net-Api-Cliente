using Cliente.Domain.Entities;
using FluentValidation;

namespace Cliente.Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;

        void Delete(Guid id);

        IList<TEntity> GetAll();

        TEntity GetById(Guid id);

        TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
    }
}
