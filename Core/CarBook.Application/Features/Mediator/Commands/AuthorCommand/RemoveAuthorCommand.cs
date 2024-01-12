using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.AuthorCommand
{
    public class RemoveAuthorCommand : IRequest
    {
        public int id { get; set; }

        public RemoveAuthorCommand(int id)
        {
            this.id = id;
        }
    }
}
