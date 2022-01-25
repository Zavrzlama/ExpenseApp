﻿using ExpensesApp.Application.Features.Currencies.Queries.GetCurrencyDetail;
using ExpensesApp.Application.Responses;

namespace ExpensesApp.Application.Features.Currencies.Commands.Create
{
    public class CreateCurrencyCommandResponse : BaseResponse
    {
        public CreateCurrencyCommandResponse() : base()
        {
        }

        public CurrencyDetailDTO Currency { get; set; }
    }
}