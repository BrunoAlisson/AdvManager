using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Número")]
        public string Number { get; set; }

        [Required]
        [ForeignKey("DocumentType")]
        [Display(Name = "Tipo de documento")]
        public int DocumentTypeId { get; set; }

        [Display(Name = "Tipo de documento")]
        public virtual DocumentType DocumentType { get; set; }
    }
}