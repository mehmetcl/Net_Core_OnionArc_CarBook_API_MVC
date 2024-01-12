using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommand
{
    public class RemoveServiceCommand : IRequest
    {
        public int id
        {
            get; set;
        }
        public RemoveServiceCommand(int id)
        {
            this.id = id;
        }
    }
}
