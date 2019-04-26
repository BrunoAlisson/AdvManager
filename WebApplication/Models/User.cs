using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(4)]
        [Display(Name = "Login")]
        public string Login { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(8)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
