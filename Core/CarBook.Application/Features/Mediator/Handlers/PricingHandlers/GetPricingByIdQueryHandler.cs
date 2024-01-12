﻿using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using CarBook.Application.Features.Mediator.Results.PricingResults;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQuery, GetPricingByIdQueryResult>
    {
        private readonly IRepository<Pricing> _repository;

        public async Task<GetPricingByIdQueryResult> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);
            return new GetPricingByIdQueryResult
            {
                Name = value.Name,
                PricingId = value.PricingId,
            };
        }
    }


}
