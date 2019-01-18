using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWithRepoPattern.Data.Repositories.Core
{
    public interface IRepository<TEntity, TContext> where TEntity : class
    {
        #region Methods
        TContext GetDataContext();

        TEntity Get(int id);


        List<TEntity> GetAll();


        void Add(TEntity entity);


        void AddRange(IEnumerable<TEntity> entities);


        void Remove(TEntity entity);


        void RemoveRange(IEnumerable<TEntity> entities);
        #endregion
    }
}
