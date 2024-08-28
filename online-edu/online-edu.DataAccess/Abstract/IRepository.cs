using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace online_edu.DataAccess.Abstract
{
	/*ASP.NET Core'da IRepository isimli bir interface, genel olarak bir veritabanı ile 
	 * etkileşim kurarken kullanılan ortak CRUD (Create, Read, Update, Delete) işlemlerini
	 * soyutlamak amacıyla kullanılır. IRepository, genellikle uygulamadaki veri erişim 
	 * mantığını merkezi bir yerde toplar ve aynı zamanda farklı veri kaynaklarıyla çalışmak
	 * için bir esneklik sağlar.*/
	public interface IRepository<T> where T : class
	{
		List<T> GetList();

		T GetByFilter(Expression<Func<T, bool>> predicate);

		T GetById(int id);

		void Create(T entity);

		void Update(T entity);

		void Delete(int id);

		int Count();

		int FilteredCount(Expression<Func<T, bool>> predicate);//predicate şartlı bir şekilde getirecek

		List<T> GetFilteredList(Expression<Func<T,bool>>predicate); //predicate şartlı bir şekilde getirecek


	}
}
