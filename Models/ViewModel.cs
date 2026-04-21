using System.ComponentModel.DataAnnotations;

namespace WEB_02.Models
{
    public class Registration
    {
        [StringLength(30, ErrorMessage = "Name length is bigger then 30 symbols")]
        [Display(Name = "Input Name")]
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Email length is bigger then 100 symbols")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        [Display(Name = "Input Email")]
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

        [Display(Name = "Input Name")]
        [Required(ErrorMessage = "Required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Subject { get; set; }
    }
}