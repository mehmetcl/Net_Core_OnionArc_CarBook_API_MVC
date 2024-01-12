using CarBook.Application.Features.RepositoryPattern.CommentRepositories;
using CarBook.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IGenericRepository<Comment> _commandRepository;

        public CommentsController(IGenericRepository<Comment> commandRepository)
        {
            _commandRepository = commandRepository;
        }

        [HttpGet]
        public IActionResult CommentList()
        {
            var values = _commandRepository.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateComment(Comment comment)
        {
            _commandRepository.Create(comment);
            return Ok("Yorum başarıyla eklendi");
        }
       
        [HttpDelete]
        public IActionResult RemoveComment(int id)
        {
          var value =  _commandRepository.GetById(id);
            _commandRepository.Remove(value);   
            return Ok("Yorum başarıyla Silindi");
        }
        [HttpPut]
        public IActionResult UpdateComment(Comment comment)
        {
            _commandRepository.Update(comment);
            return Ok("Yorum başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetComment(int id)
        {
            var value = _commandRepository.GetById(id);
            return Ok(value);
        }
    }
}
