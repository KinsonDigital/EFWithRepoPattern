using System.Collections.Generic;
using System.Linq;
using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.Data.Repositories.Core;
using EFWithRepoPattern.Data.Repositories.DataContext;

namespace EFWithRepoPattern.Data.Repositories
{
    /// <summary>
    /// Pulls and pushes data to the database related to <see cref="Company"/> data.
    /// </summary>
    public class CompanyRepository : Repository<Company, TestDBContext>
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of <see cref="CompanyRepository"/>.
        /// </summary>
        /// <param name="context">The database context of where the <see cref="Company"/> data is located.</param>
        public CompanyRepository(TestDBContext context) : base(context)
        {
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Gets all of the data related to companies.
        /// </summary>
        /// <returns></returns>
        public override List<Company> GetAll()
        {
            return Context.Companies.ToList();
        }
        #endregion
    }
}
