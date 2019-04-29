using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        public virtual ICollection<Document> Documents { get; set; }
    }
}
