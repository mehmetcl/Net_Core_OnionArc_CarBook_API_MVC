
using CarBook.Application.Interfaces.BlogRepositories;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookDbContext _context;

        public BlogRepository(CarBookDbContext context)
        {
            _context = context;
        }

		public List<Blog> GetAllBlogsWithAuthors()
		{
			var values = _context.Blogs.Include(x => x.Author).Include(y=>y.Category).ToList();
			return values;
		}

		public List<Blog> GetLast3BlogWithAuthors()
        {
            var values = _context.Blogs.Include(x=>x.Author).OrderByDescending(x=>x.BlogID).Take(3).ToList();
            return values;
        }
    }
}
