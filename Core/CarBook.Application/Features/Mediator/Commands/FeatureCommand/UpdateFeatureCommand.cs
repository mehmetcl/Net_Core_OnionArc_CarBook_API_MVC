﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FeatureCommand
{
    public class UpdateFeatureCommand:IRequest
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
    }
}
