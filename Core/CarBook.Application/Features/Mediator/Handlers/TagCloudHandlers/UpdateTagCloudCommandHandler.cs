﻿using CarBook.Application.Features.Mediator.Commands.TagCloudCommand;
using CarBook.Application.Features.Mediator.Commands.TestimonialCommand;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class UpdateTagCloudCommandHandler : IRequestHandler<UpdateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public UpdateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.TagCloudId);

            values.TagCloudId = request.TagCloudId;
            values.Title = request.Title;
            values.BlogId = request.BlogId;


            await _repository.UpdateAsync(values);
        }
    }
}
