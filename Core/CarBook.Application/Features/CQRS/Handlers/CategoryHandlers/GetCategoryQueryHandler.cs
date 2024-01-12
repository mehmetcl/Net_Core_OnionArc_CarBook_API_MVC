using CarBook.Application.Features.CQRS.Results.CategoryResult;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {

        private readonly IRepository<Category> _respository;

        public GetCategoryQueryHandler(IRepository<Category> respository)
        {
            _respository = respository;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _respository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
               
                Name = x.Name,
                CategoryId = x.CategoryId,

            }).ToList();
        }
    }
}
