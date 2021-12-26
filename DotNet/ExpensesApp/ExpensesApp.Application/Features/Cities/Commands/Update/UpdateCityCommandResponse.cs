using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.Cities.Commands.Update
{
    public class UpdateCityCommandResponse : BaseResponse
    {
        public bool IsFound { get; set; }

    }
}
