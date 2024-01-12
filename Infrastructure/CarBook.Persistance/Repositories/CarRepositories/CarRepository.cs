using CarBook.Application.Interfaces.CarRepositories;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookDbContext _context;

        public CarRepository(CarBookDbContext context)
        {
            _context = context;
        }

        public List<Car> GetCarsListWithBrand()
        {
            var values= _context.Cars.Include(x=>x.Brand).ToList(); 
            return values;
        }

		public List<Car> GetLast5CarsWithBrand()
        {
            var values = _context.Cars.Include(x => x.Brand).OrderByDescending(x=>x.CarId).Take(5).ToList();
            return values;
        }
		
	}
}
