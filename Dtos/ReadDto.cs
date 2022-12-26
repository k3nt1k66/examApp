namespace WebApplication2.Dtos
{

    public class PersonDto
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class EmailAddressDto
    {
        public int EmailAddressId { get; set; }
        public string Email { get; set; }
    }
}
