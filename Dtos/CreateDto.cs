using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Dtos
{
    public class PersonDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }

    public class EmailAddressDto
    {
        [Required]
        public string Email { get; set; }
    }
}