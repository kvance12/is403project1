

using System.ComponentModel.DataAnnotations;
namespace MVCEmail.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required, Display(Name = "Subject")]
        public string FromSubject { get; set; }
        [Required]
        public string Message { get; set; }     
       public string Question { get; set; }
    }
}
