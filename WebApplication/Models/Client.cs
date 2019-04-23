using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
