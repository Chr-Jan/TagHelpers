using System.ComponentModel.DataAnnotations;

namespace TagHelpers.Models
{
    public class Human
    {
        [Required(ErrorMessage = "Everybody have a name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "thath is not possible")]
        public string Name { get; set; }
        [Range(0, 120, ErrorMessage = "you cant be more than 120 or less than 0")]
        public int Age { get; set; }

        public bool Handsome { get; set; }
    }
}
