using CarBook.Application.Features.CQRS.Results.CarResult;
using CarBook.Application.Interfaces;
using CarBook.Application.Interfaces.CarRepositories;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLas5CarWithBrandQueryHandler
    {
        private readonly ICarRepository _respository;

        public GetLas5CarWithBrandQueryHandler(ICarRepository respository)
        {
            _respository = respository;
        }

        public  List<GetLas5CarWithBrandQueryResult> Handle()
        {
            var values =  _respository.GetLast5CarsWithBrand();
            return values.Select(x => new GetLas5CarWithBrandQueryResult {

                CarId = x.CarId,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seats = x.Seats,
                Transmission = x.Transmission,
                BrandName = x.Brand.Name,



            }).ToList();
        }
    }
}
