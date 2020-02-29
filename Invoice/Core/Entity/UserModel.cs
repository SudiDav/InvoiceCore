using Invoice.Core.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace Invoice.Core.Entity
{
    public class UserModel : BaseModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(5)]
        public string Password { get; set; }
        [Compare("Password")]
        [Required]
        public string ConfirmPassword { get; set; }
    }
}
