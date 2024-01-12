using CarBook.Application.Features.CQRS.Results.BannerResult;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _respository;

        public GetBannerQueryHandler(IRepository<Banner> respository)
        {
            _respository = respository;
        }

        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _respository.GetAllAsync();
            return values.Select(x=>new GetBannerQueryResult
            {
                BannerID = x.BannerID,  
                Description = x.Description,    
                Title = x.Title,    
                VideoDescription = x.VideoDescription,  
                VideoUrl = x.VideoUrl   
            }).ToList();
        }
    }
}
