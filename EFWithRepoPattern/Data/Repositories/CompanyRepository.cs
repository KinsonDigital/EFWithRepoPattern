using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.Data.Repositories.Core;
using EFWithRepoPattern.Data.Repositories.DataContext;

namespace EFWithRepoPattern.Data.Repositories
{
    public class CompanyRepository : Repository<Company, TestDBContext>
    {
        private TestDBContext _context;


        public CompanyRepository() : base(new TestDBContext())
        {
            _context = GetDataContext();
        }

        public override List<Company> GetAll()
        {
            return _context.Companies.ToList();
        }
    }
}
