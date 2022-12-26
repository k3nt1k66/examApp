using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Person
    {
        [Key]
        [Required]
        public int PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public List<EmailAddress> EmailAddresses { get; set; }

        public List<PersonPhone> PersonPhones { get; set; }
    }

    public class EmailAddress
    {

        [Required]
        public int EmailAddressId { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public Person Person { get; set; }
    }

    public class PersonPhone
    {

        [Required]
        public int PersonPhoneId { get; set; }

        [Required]
        public int PersonId { get; set; }

        [Required]
        public int PhoneNumberTypeId { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public Person Person { get; set; }
        public PhoneNumberType PhoneNumberType { get; set; }
    }

    public class PhoneNumberType
    {

        [Required]
        public int PhoneNumberTypeId { get; set; }

        [Required]
        public string Name { get; set; }
        public List<PersonPhone> PersonPhones { get; set; }
    }
}
