using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.Data.Repositories.Core;
using EFWithRepoPattern.Data.Repositories.DataContext;
using System.Collections.Generic;
using System.Linq;

namespace EFWithRepoPattern.Data.Repositories
{
    /// <summary>
    /// Pulls and pushes data to the database related to <see cref="Employee"/> data.
    /// </summary>
    public class EmployeeRepository : Repository<Employee, TestDBContext>
    {
        #region Constructor
        /// <summary>
        /// Creates a new instance of <see cref="EmployeeRepository"/>.
        /// </summary>
        /// <param name="context">The database context of where the company <see cref="Employee"/> data is located.</param>
        public EmployeeRepository(TestDBContext context) : base(context)
        {
        }
        #endregion


        #region Public Methods
        /// <summary>
        /// Gets all of the employees that belong to the <see cref="Company"/> with the given <paramref name="companyId"/>.
        /// </summary>
        /// <param name="companyId"></param>
        /// <returns></returns>
        public List<Employee> GetEmployees(int companyId)
        {
            return (from e in Context.Employees
                    where e.CompanyID == companyId
                    select e).ToList();
        }
        #endregion
    }
}
