using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.BlogRepositories
{
    public interface IBlogRepository
    {
        public List<Blog> GetLast3BlogWithAuthors();

		public List<Blog> GetAllBlogsWithAuthors();
	}
}
