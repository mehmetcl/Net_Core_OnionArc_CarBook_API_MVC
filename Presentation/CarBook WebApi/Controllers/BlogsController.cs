
using CarBook.Application.Features.Mediator.Commands.BlogCommand;
using CarBook.Application.Features.Mediator.Queries.BlogQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await _mediator.Send(new GetBlogQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var values = await _mediator.Send(new GetBlogByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok("Blog başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _mediator.Send(command);

            return Ok("Blog başarıyla güncellendi");
        }
        [HttpGet("GetLast3BlogsWithAuthorList")]
        public async Task<IActionResult> GetLast3BlogsWithAuthorList()
        {
            var values = await _mediator.Send(new GetLast3BlogsWithAuthorQuery());
            return Ok(values);
        }

		
		[HttpGet("GetAllBlogsWithAuthorsList")]
		public async Task<IActionResult> GetAllBlogsWithAuthorsList()
		{
			var values = await _mediator.Send(new GetAllBlogsWithAuthorQuery());
			return Ok(values);
		}


    }
}
