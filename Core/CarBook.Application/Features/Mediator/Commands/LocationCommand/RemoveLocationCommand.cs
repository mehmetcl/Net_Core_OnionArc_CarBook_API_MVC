﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.LocationCommand
{
    public class RemoveLocationCommand : IRequest
    {
        public  int id { get; set; }

        public RemoveLocationCommand(int id)
        {
            this.id = id;
        }
    }
}
