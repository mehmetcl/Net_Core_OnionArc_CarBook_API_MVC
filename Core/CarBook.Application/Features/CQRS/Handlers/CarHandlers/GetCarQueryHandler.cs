using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _respository;

        public GetCarQueryHandler(IRepository<Car> respository)
        {
            _respository = respository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _respository.GetAllAsync();
            return values.Select(x => new GetCarQueryResult
            {
                CarId = x.CarId,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,    
                CoverImageUrl = x.CoverImageUrl,    
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seats = x.Seats,    
                Transmission = x.Transmission   

            }).ToList();
        }
    }
}
