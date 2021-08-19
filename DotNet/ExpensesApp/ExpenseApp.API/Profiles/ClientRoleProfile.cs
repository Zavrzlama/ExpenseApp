using AutoMapper;

namespace ExpensesApp.API.Profiles
{
    public class ClientRoleProfile : Profile
    {
        public ClientRoleProfile()
        {
            CreateMap<Entities.ClientRole, Models.ClientRoleDTO>();
            CreateMap<Models.ClientRoleInsertDTO, Entities.ClientRole>().ReverseMap();
        }
    }
}
