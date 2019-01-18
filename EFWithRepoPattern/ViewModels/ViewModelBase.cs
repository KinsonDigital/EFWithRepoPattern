using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.Data.Repositories.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EFWithRepoPattern.ViewModels
{
    /// <summary>
    /// Provides the basic functionality of a view model.
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion


        #region Fields
        protected IRepository<Company> _repository;
        #endregion


        #region Constructors
        /// <summary>
        /// Creates a new instance of <see cref="ViewModelBase"/>.
        /// </summary>
        /// <param name="repository">The repository used to get the view model related data.</param>
        public ViewModelBase(IRepository<Company> repository)
        {
            _repository = repository;
        }
        #endregion


        #region Protected Methods
        /// <summary>
        /// Notifies the binding system that a property value has changed.
        /// </summary>
        /// <param name="propName"></param>
        protected void NotifyPropChange([CallerMemberName] string propName = "")
        {
            if (!string.IsNullOrEmpty(propName))
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        #endregion
    }
}
