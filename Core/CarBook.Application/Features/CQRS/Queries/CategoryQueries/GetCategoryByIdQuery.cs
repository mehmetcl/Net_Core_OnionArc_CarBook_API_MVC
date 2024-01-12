using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public int id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            this.id = id;
        }
    }
}
