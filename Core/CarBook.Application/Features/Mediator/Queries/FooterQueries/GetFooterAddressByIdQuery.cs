using CarBook.Application.Features.Mediator.Results.FooterAddressesResult;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.FooterQueries
{
    public class GetFooterAddressByIdQuery:IRequest<GetFooterAddressByIdQueryResult>
    {
        public int id { get; set; }

        public GetFooterAddressByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
