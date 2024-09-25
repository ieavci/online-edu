using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using online_edu.Entity.Entities;

namespace online_edu.DataAccess.Abstract
{
	public interface IBlogRepository:IRepository<Blog>
	{
		List<Blog> GetBlogsWithCategories();
	}
}
