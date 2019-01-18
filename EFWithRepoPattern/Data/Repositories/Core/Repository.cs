using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EFWithRepoPattern.Data.Repositories.Core
{
    /// <summary>
    /// Provides basic functionality for pulling and pushing data to a database related to the given
    /// <typeparamref name="TEntity"/> under the given <typeparamref name="TContext"/> database context.
    /// </summary>
    /// <typeparam name="TEntity">The type of entite in the database to manipulate.</typeparam>
    /// <typeparam name="TContext">The database context of where the data is located.</typeparam>
    public abstract class Repository<TEntity, TContext> : IRepository<TEntity> where TEntity : class where TContext : DbContext
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of <see cref="Repository{TEntity, TContext}"/>.
        /// </summary>
        /// <param name="context">The database context of where the data is located.</param>
        public Repository(TContext context)
        {
            Context = context;
        }
        #endregion


        #region Props
        /// <summary>
        /// Gets or sets the database context of where the data is located.
        /// </summary>
        protected TContext Context { get; set; }
        #endregion


        #region public virtual Methods
        /// <summary>
        /// Adds the given <paramref name="entity"/> to the database.
        /// </summary>
        /// <param name="entity">The entity data to add.</param>
        public virtual void Add(TEntity entity)
        {
            throw new NotImplementedException($"The method {nameof(Add)} must be override the {nameof(Repository<TEntity, TContext>)} class.");
        }


        /// <summary>
        /// Adds the given list of <paramref name="entities"/> to the database.
        /// </summary>
        /// <param name="entities">The list of entities to add.</param>
        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException($"The method {nameof(AddRange)} must be override the {nameof(Repository<TEntity, TContext>)} class.");
        }


        /// <summary>
        /// Gets an entity of type <see cref="TEntity"/> from the database that matches the given <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The id of the record to get.</param>
        /// <returns></returns>
        public virtual TEntity Get(int id)
        {
            throw new NotImplementedException($"The method {nameof(Get)} must be override the {nameof(Repository<TEntity, TContext>)} class.");
        }


        /// <summary>
        /// Gets all of the records of the type <typeparamref name="TEntity"/> from the database.
        /// </summary>
        /// <returns></returns>
        public virtual List<TEntity> GetAll()
        {
            throw new NotImplementedException($"The method {nameof(GetAll)} must be override the {nameof(Repository<TEntity, TContext>)} class.");
        }


        /// <summary>
        /// Removes a single record of the type <typeparamref name="TEntity"/> from the database.
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Remove(TEntity entity)
        {
            throw new NotImplementedException($"The method {nameof(Remove)} must be override the {nameof(Repository<TEntity, TContext>)} class.");
        }


        /// <summary>
        /// Removes the list of given <paramref name="entities"/> of type <typeparamref name="TEntity"/> from the database.
        /// </summary>
        /// <param name="entities"></param>
        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException($"The method {nameof(RemoveRange)} must be override the {nameof(Repository<TEntity, TContext>)} class.");
        }
        #endregion
    }
}
