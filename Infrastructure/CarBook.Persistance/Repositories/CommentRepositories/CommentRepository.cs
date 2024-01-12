using CarBook.Application.Features.RepositoryPattern.CommentRepositories;
using CarBook.Application.Repositories;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.CommentRepositories
{
    public class CommentRepository<T> : IGenericRepository<Comment>
    {
        private readonly CarBookDbContext _context;

        public CommentRepository(CarBookDbContext context)
        {
            _context = context;
        }

        public void Create(Comment entity)
        {
          
        }

        public List<Comment> GetAll()
        {
           return _context.Comments.Select(x=> new Comment
           {
               CommentId = x.CommentId, 
               Name = x.Name,    
               BlogtId = x.BlogtId, 
               CreatedDate = x.CreatedDate,
               Description = x.Description  
           }).ToList();
        }

        public Comment GetById(int id)
        {
           return _context.Comments.Find(id);
        }


        public void Remove(Comment entity)
        {
            var value = _context.Comments.Find(entity.CommentId);
            _context.Remove(value);
            _context.SaveChanges();
        }

        public void Update(Comment entity)
        {
          
        }
    }
}
