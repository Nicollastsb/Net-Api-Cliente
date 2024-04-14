using System.ComponentModel.DataAnnotations;

namespace Cliente.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
    }
}
