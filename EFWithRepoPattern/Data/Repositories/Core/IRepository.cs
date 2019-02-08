using System.Collections.Generic;

namespace EFWithRepoPattern.Data.Repositories.Core
{
    /// <summary>
    /// Provides basic functionality for pulling and pushing data to a datasource/database related to the given
    /// <typeparamref name="TEntity"/> under the given <typeparamref name="TContext"/> database context.
    /// </summary>
    /// <typeparam name="TEntity">The type of entite in the database to manipulate.</typeparam>
    /// <typeparam name="TContext">The database context of where the data is located.</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Methods
        /// <summary>
        /// Adds the given <paramref name="entity"/> to the database.
        /// </summary>
        /// <param name="entity">The entity data to add.</param>
        void Add(TEntity entity);


        /// <summary>
        /// Adds the given list of <paramref name="entities"/> to the database.
        /// </summary>
        /// <param name="entities">The list of entities to add.</param>
        void AddRange(IEnumerable<TEntity> entities);


        /// <summary>
        /// Gets an entity of type <see cref="TEntity"/> from the database that matches the given <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The id of the record to get.</param>
        /// <returns></returns>
        TEntity Get(int id);


        /// <summary>
        /// Gets all of the records of the type <typeparamref name="TEntity"/> from the database.
        /// </summary>
        /// <returns></returns>
        List<TEntity> GetAll();


        /// <summary>
        /// Removes a single record of the type <typeparamref name="TEntity"/> from the database.
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);


        /// <summary>
        /// Removes the list of given <paramref name="entities"/> of type <typeparamref name="TEntity"/> from the database.
        /// </summary>
        /// <param name="entities"></param>
        void RemoveRange(IEnumerable<TEntity> entities);
        #endregion
    }
}
