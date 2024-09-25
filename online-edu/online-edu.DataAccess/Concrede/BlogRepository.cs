using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using online_edu.DataAccess.Abstract;
using online_edu.DataAccess.Context;
using online_edu.DataAccess.Repositories;
using online_edu.Entity.Entities;

namespace online_edu.DataAccess.Concrede
{
	public class BlogRepository : GenericRepository<Blog>, IBlogRepository
	{
		private readonly online_eduContext _educontext;
		public BlogRepository(online_eduContext _context) : base(_context)
		{
			_educontext = _context;
		}

		public List<Blog> GetBlogsWithCategories()
		{
			return _educontext.Blogs.Include(x=>x.BlogCategory).ToList();
		}
	}
}
