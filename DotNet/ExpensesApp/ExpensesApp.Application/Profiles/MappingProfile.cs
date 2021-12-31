using System.Security.Claims;
using AutoMapper;
using ExpensesApp.Application.Features.Cities.Commands.Create;
using ExpensesApp.Application.Features.Cities.Queries.GetCityDetail;
using ExpensesApp.Application.Features.Cities.Queries.GetCityList;
using ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole;
using ExpensesApp.Application.Features.ClientRoles.Commands.UpdateClientRole;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleDetail;
using ExpensesApp.Application.Features.ClientRoles.Queries.GetClientRoleList;
using ExpensesApp.Application.Features.Clients.Commands.CreateClient;
using ExpensesApp.Application.Features.Clients.Commands.UpdateClient;
using ExpensesApp.Application.Features.Clients.Queries.GetClientDetail;
using ExpensesApp.Application.Features.Clients.Queries.GetClientList;
using ExpensesApp.Domain.Entities;

namespace ExpensesApp.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Client roles
            CreateMap<ClientRole, ClientRolesListDTO>().ReverseMap();
            CreateMap<ClientRole, GetClientRolesDetailQuery>().ReverseMap();
            CreateMap<ClientRole, CreateClientRoleCommand>().ReverseMap();
            CreateMap<ClientRole, ClientRoleDetailDTO>().ReverseMap();
            CreateMap<ClientRole,UpdateClientRoleCommand>().ReverseMap();

            //Clients
            CreateMap<Client, ClientsListDTO>().ReverseMap();
            CreateMap<Client, ClientDetailDTO>().ReverseMap();
            CreateMap<Client, CreateClientCommand>().ReverseMap();
            CreateMap<Client, UpdateClientCommand>().ReverseMap();

            //Cities
            CreateMap<City, GetCityListQuery>().ReverseMap();
            CreateMap<City, CreateCityCommand>().ReverseMap();
            CreateMap<City, CityDetailDTO>().ReverseMap();

        }
    }
}