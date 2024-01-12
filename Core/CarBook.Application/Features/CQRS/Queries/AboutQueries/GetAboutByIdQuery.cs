using CarBook.Application.Features.Mediator.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.AboutQueries
{
    public class GetAboutByIdQuery:IRequest<GetAuthorByIdQueryResult>
    {

        public int id { get; set; }

        public GetAboutByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
