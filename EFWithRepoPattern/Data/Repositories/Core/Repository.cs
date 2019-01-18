using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWithRepoPattern.Data.Repositories.Core
{
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        #region Props
        private DbContext Context { get; set; }
        #endregion


        #region Constructors
        public Repository(DbContext context)
        {
            Context = context;
        }
        #endregion


        #region Public Methods
        public TContext GetDataContext()
        {
            return Context as TContext;
        }


        public void Add(TEntity entity)
        {
        }


        public void AddRange(IEnumerable<TEntity> entities)
        {
        }


        public TEntity Get(int id)
        {
            return null;
        }


        public virtual List<TEntity> GetAll()
        {
            throw new NotImplementedException($"The method {nameof(GetAll)} must be override the {nameof(Repository<TEntity, TContext>)} class.");
        }


        public void Remove(TEntity entity)
        {
        }


        public void RemoveRange(IEnumerable<TEntity> entities)
        {
        }
        #endregion
    }
}
