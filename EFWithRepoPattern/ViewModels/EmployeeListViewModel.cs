using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.Data.Repositories;

namespace EFWithRepoPattern.ViewModels
{
    /// <summary>
    /// Creates a new instance of <see cref="EmployeeListViewModel"/>.
    /// </summary>
    public class EmployeeListViewModel : ViewModelBase
    {
        #region Fields
        private EmployeeRepository _repository;
        private int _companyId;
        #endregion


        #region Constructors
        /// <summary>
        /// Creates a new instance of <see cref="EmployeeListViewModel"/>.
        /// </summary>
        /// <param name="repository">The repository used to get the data.</param>
        public EmployeeListViewModel(EmployeeRepository repository)
        {
            _repository = repository;
        }
        #endregion


        #region Props
        /// <summary>
        /// Gets or sets the company ID of the company that the employees belong to.
        /// </summary>
        public int CompanyId
        {
            get => _companyId;
            set
            {
                _companyId = value;
                Employees = _repository.GetEmployees(value).ToArray();
                NotifyPropChange(nameof(Employees));
            }
        }

        /// <summary>
        /// The list of employees of a <see cref="Company"/>.
        /// </summary>
        public Employee[] Employees { get; private set; }
        #endregion
    }
}
