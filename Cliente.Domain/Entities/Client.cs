using System.ComponentModel.DataAnnotations;

namespace Cliente.Domain.Entities
{
    public class Client : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string CPF { get; set; }
        [Required]
        [MaxLength(50)]
        public string Sex { get; set; }
        [Required]
        [MaxLength(50)]
        public string Telephone { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [MaxLength(100)]
        public string? Observation { get; set; }
    }
}
