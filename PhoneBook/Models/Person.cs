using PhoneBook.Utils;
using System.ComponentModel.DataAnnotations;

namespace PhoneBook.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        
        [Display(Name = "Mobile Number")]
        [Phone]
        public string MobilePhoneNumber { get; set; }


        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Job { get; set; }

        [Display(Name = "Home Number")]
        [Required]
        [Phone]
        public string HomePhoneNumber { get; set; }

        [Range(0, 200)]
        public string Age { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string HomeAddress { get; set; }

        public string City { get; set; }


    }
}
