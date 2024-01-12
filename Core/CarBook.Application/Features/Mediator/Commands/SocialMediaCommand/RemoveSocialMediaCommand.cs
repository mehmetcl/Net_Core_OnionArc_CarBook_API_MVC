﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.SocialMediaCommand
{
    public class RemoveSocialMediaCommand : IRequest
    {
        public int id
        {
            get; set;
        }
        public RemoveSocialMediaCommand(int id)
        {
            this.id = id;
        }
    }
}
