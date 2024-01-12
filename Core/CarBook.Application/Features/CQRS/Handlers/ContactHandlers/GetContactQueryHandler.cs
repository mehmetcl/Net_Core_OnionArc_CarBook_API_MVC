using CarBook.Application.Features.CQRS.Results.ContactResult;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _respository;

        public GetContactQueryHandler(IRepository<Contact> respository)
        {
            _respository = respository;
        }

        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _respository.GetAllAsync();
            return values.Select(x => new GetContactQueryResult
            {

                Name = x.Name,
                ContactId = x.ContactId,
                Email = x.Email,
                Message = x.Message,
                SendDate = x.SendDate,      
                Subject = x.Subject 

            }).ToList();
        }
    }
}
