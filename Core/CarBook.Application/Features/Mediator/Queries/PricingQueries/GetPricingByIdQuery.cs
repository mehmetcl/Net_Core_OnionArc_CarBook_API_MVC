using CarBook.Application.Features.Mediator.Results.PricingResults;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIdQuery:IRequest<GetPricingByIdQueryResult>  
    {
        public int id { get; set; }

        public GetPricingByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
