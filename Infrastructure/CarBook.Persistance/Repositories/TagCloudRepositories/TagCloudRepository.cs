using CarBook.Application.Interfaces.TagCloudRepositories;
using CarBook.Domain.Entities;
using CarBook.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistance.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepositorty
    {
        private readonly CarBookDbContext _context;

        public TagCloudRepository(CarBookDbContext context)
        {
            _context = context;
        }

        public List<TagCloud> GetTagCloudByBlogID(int id)
        {
            var values = _context.TagClouds.Where(x=>x.BlogId == id).ToList();  
            return values;
            
        }
    }
}
