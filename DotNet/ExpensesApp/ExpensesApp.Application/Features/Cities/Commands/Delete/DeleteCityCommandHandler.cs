using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ExpensesApp.Application.Features.Cities.Commands.Delete
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand>
    {
        public async Task<Unit> Handle(DeleteCityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
