﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FooterAddressCommand
{
    public class RemoveFooterAddressCommand:IRequest
    {
        public int id { get; set; }

        public RemoveFooterAddressCommand(int id)
        {
            this.id = id;
        }
    }
}
