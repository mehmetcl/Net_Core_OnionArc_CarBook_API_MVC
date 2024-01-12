using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.TagCloudCommand
{
    public class RemoveTagCloudCommand:IRequest
    {
        public int id { get; set; }

        public RemoveTagCloudCommand(int id)
        {
            this.id = id;
        }
    }
}
