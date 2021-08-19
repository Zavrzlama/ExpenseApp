using AutoMapper;

namespace ExpensesApp.API.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Entities.Client, Models.ClientDTO>()
                .ForMember(dest => dest.ClientRoleDto, act => act.MapFrom(src => src.ClientRole));
            CreateMap<Models.ClientForInsertDTO, Entities.Client>();
        }
    }
}