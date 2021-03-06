﻿using System.Data.Entity;
using WebSite.DAL;
using WebSite.IDAL.SingletonGenericPattern;
using WebSite.IDAL.SingletonPattern;

namespace WebSite.DALFactory.SingletonGenericPattern
{
	public class DbGenericSession<T, M> : IDbGenericSession<T, M> where T : class, IBaseDal<M> where M : class, new()
	{
		public DbContext DbContext { get { return DbContextFactory.CreateDbContext(); } }

		private T m_createInstanceDal = null;

		public T CreateInstanceDal
		{
			get
			{
				if (m_createInstanceDal == null)
				{
					m_createInstanceDal = AbstractFactory.CreateInstanceDal<T>();
				}
				return m_createInstanceDal;
			}
		}

		/// <summary>
		/// 一个业务中经常涉及到对多张操作，我们希望链接一次数据库，完成对张表数据的操作。提高性能。 工作单元模式。
		/// </summary>
		/// <returns></returns>
		public bool SaveChanged()
		{
			return DbContext.SaveChanges() > 0;
		}

		public void Dispose()
		{
			DbContext.Dispose();
		}
	}
}
