using System.ComponentModel.DataAnnotations;

namespace AppRazorApplication.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Lastname")]
        public string lastname { get; set; }
        public string email { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string photo { get; set; }

        public DateTime creation_date { get; set; }
    }
}
