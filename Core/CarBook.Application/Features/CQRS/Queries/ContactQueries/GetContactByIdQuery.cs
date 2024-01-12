using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.ContactQueries
{
    public class GetContactByIdQuery
    {
        public int id { get; set; }

        public GetContactByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
