using System.Configuration;
using System.Data.Entity;
using EFWithRepoPattern.Data.Entities;

namespace EFWithRepoPattern.Data.Repositories.DataContext
{
    /// <summary>
    /// Represents the TestDB database and its associated data.
    /// </summary>
    public class TestDBContext : DbContext
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of <see cref="TestDBContext"/>.
        /// </summary>
        public TestDBContext() : base(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString)
        {
            
        }
        #endregion


        #region DB Set Props
        /// <summary>
        /// Gets or sets the <see cref="Company"/> table data set
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Employee"/> table data set
        /// </summary>
        public DbSet<Employee> Employees { get; set; }
        #endregion
    }
}
