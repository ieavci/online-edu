using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using online_edu.DataAccess.Abstract;
using online_edu.DataAccess.Context;

namespace online_edu.DataAccess.Repositories
{
	public class GenericRepository<T>(online_eduContext _context) : IRepository<T> where T : class //(online_eduContext _context) bu kısım contexti geçirdiğimiz kısım. 8.0 sürümü ile güncellenmiş hali. (primary constructor yapısı olarak geçiyor)
	{

		public DbSet<T> Table { get => _context.Set<T>(); } 
		public int Count()
		{
			return Table.Count();
		}

		public void Create(T entity)
		{
			Table.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			var entity=Table.Find(id);
			Table.Remove(entity);
			_context.SaveChanges();
		}

		public int FilteredCount(Expression<Func<T, bool>> predicate)
		{
			return Table.Where(predicate).Count();
		}

		public T GetByFilter(Expression<Func<T, bool>> predicate)
		{
			return Table.Where(predicate).FirstOrDefault();
		}

		public T GetById(int id)
		{
			return Table.Find(id);
		}

		public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
		{
			return Table.Where(predicate).ToList();
		}

		public List<T> GetList()
		{
			return Table.ToList();
		}

		public void Update(T entity)
		{
			Table.Update(entity);
			_context.SaveChanges();
		}
	}
}
