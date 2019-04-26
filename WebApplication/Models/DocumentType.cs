using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class DocumentType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
