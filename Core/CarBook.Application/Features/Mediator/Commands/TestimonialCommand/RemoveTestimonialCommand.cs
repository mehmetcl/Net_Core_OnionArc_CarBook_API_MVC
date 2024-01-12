using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.TestimonialCommand
{
    public class RemoveTestimonialCommand : IRequest
    {
        public  int id { get; set; }

        public RemoveTestimonialCommand(int id)
        {
            this.id = id;
        }
    }
}
