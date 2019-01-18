using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.Data.Repositories.Core;
using EFWithRepoPattern.Data.Repositories.DataContext;

namespace EFWithRepoPattern.ViewModels
{
    public class CompanyListViewModel
    {
        private IRepository<Company, TestDBContext> _repository;

        public CompanyListViewModel(IRepository<Company, TestDBContext> repository)
        {
            _repository = repository;

            var result = _repository.GetAll();

            //var totalEmployees = result[0].Employees.Count;

            //var employee = result[0].Employees.ToList()[0];

            //var firstEmployeeFullname = $"{employee.FirstName} {employee.LastName}";
        }

        public ObservableCollection<Company> Companies { get; set; }
    }
}
