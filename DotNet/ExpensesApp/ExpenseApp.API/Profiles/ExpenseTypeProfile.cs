using AutoMapper;

namespace ExpensesApp.API.Profiles
{
    public class ExpenseTypeProfile : Profile
    {
        public ExpenseTypeProfile()
        {
            CreateMap<Entities.ExpenseType, Models.ExpenseTypeDTO>();
        }
    }
}