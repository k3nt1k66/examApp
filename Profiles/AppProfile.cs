public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Person, PersonDto>();
        CreateMap<EmailAddress, EmailAddressDto>();
    }
}