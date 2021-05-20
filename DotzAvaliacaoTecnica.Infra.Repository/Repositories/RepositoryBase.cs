using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.DomainCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DotzAvaliacaoTecnica.Infra.Repository.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
	{
		protected readonly DbContext Context;
		private DbSet<TEntity> _entities;

		public RepositoryBase(DbContext context)
		{
			Context = context;
			_entities = Context.Set<TEntity>();
		}

		public virtual TEntity Get(int id)
		{
			return _entities.Find(id);
		}

		public virtual IEnumerable<TEntity> GetAll()
		{
			return _entities.ToList();
		}

		public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
		{
			return _entities.Where(predicate);
		}

		public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return _entities.SingleOrDefault(predicate);
		}

		public virtual void Add(TEntity entity)
		{
			_entities.Add(entity);
		}

		

		public virtual void Remove(TEntity entity)
		{
			_entities.Remove(entity);
		}
		public virtual void Update(TEntity entity)
		{
			_entities.Update(entity);
		}
	}
}
