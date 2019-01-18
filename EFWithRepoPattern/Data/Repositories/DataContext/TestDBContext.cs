using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWithRepoPattern.Data.Entities;

namespace EFWithRepoPattern.Data.Repositories.DataContext
{
    public class TestDBContext : DbContext
    {
        public TestDBContext() : base(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString)
        {
        }


        #region DB Set Props
        public DbSet<Company> Companies { get; set; }
        #endregion
    }
}
