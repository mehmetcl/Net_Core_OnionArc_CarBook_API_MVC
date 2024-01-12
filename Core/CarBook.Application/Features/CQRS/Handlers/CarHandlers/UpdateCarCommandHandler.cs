using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
         private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var values = await _repository.GetByIdAsync(command.CarID);

            values.Fuel = command.Fuel;
            values.CarId = command.CarID;   
            values.Transmission = command.Transmission; 
            values.CoverImageUrl= command.CoverImageUrl;    
            values.BigImageUrl= command.BigImageUrl;    
            values.Km= command.Km;  
            values.BrandID= command.BrandID;    
            values.Luggage= command.Luggage;
            values.Model= command.Model;    
            values.Seats= command.Seats;    

            await _repository.UpdateAsync(values);
        }
    }
}
