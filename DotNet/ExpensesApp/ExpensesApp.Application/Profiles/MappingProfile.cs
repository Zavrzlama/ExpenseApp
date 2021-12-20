using AutoMapper;
using ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleList;
using ExpensesApp.Application.Features.Clients.Commands.CreateClient;
using ExpensesApp.Application.Features.Clients.Queries.GetClientDetail;
using ExpensesApp.Application.Features.Clients.Queries.GetClientList;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ClientRole, ClientRolesListDTO>().ReverseMap();
            CreateMap<ClientRole, GetClientRolesDetailQuery>().ReverseMap();
            CreateMap<ClientRole, CreateClientRoleCommand>().ReverseMap();
            CreateMap<ClientRole, ClientRoleDetailDTO>().ReverseMap();
            CreateMap<Client, GetClientsListDTO>().ReverseMap();
            CreateMap<Client, GetClientDetailDTO>().ReverseMap();
            CreateMap<Client, CreateClientCommand>().ReverseMap();
        }
    }
}