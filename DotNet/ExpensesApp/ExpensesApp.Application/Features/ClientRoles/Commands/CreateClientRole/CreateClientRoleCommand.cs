using System;
using MediatR;

namespace ExpensesApp.Application.Features.ClientRoles.Commands.CreateClientRole
{
    public class CreateClientRoleCommand : IRequest<CreateClientRoleCommandResponse>
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
    }
}