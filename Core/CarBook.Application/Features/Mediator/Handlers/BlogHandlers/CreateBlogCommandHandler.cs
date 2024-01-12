﻿using CarBook.Application.Features.Mediator.Commands.BlogCommand;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {

            await _repository.CreateAsync(new Blog
            {
                AuthorID = request.AuthorID,
                Title = request.Title,
                CreatedDate = request.CreatedDate,
                CoverImageUrl = request.CoverImageUrl,
                CategoryID = request.CategoryID,    
                Description = request.Description,  
               
            });
        }
    }
}
