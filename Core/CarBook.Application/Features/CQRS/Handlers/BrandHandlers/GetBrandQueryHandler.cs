using CarBook.Application.Features.CQRS.Results.BannerResult;
using CarBook.Application.Features.CQRS.Results.BrandResult;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Brand> _respository;

        public GetBrandQueryHandler(IRepository<Brand> respository)
        {
            _respository = respository;
        }

        public async Task<List<GetBrandQueryResult>> Handle()
        {
            var values = await _respository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                BrandID = x.BrandID,
                Name = x.Name,

            }).ToList();
        }
    }
}
