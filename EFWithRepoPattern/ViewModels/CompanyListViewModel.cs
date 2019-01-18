using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.Data.Repositories;

namespace EFWithRepoPattern.ViewModels
{
    /// <summary>
    /// Holds all of the company related data for all companies.
    /// </summary>
    public class CompanyListViewModel : ViewModelBase
    {
        #region Fields
        private CompanyRepository _repository;
        #endregion


        #region Constructors
        /// <summary>
        /// Creates a new instance of <see cref="CompanyListViewModel"/>.
        /// </summary>
        /// <param name="repository">The repository used to get the data.</param>
        public CompanyListViewModel(CompanyRepository repository)
        {
            _repository = repository;
            Companies = _repository.GetAll().ToArray();
        }
        #endregion


        #region Props
        /// <summary>
        /// Gets or sets the list of companies.
        /// </summary>
        public Company[] Companies { get; set; }
        #endregion
    }
}
