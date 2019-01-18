using EFWithRepoPattern.Data.Entities;
using EFWithRepoPattern.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EFWithRepoPattern.UserControls
{
    /// <summary>
    /// Interaction logic for CompanyList.xaml
    /// </summary>
    public partial class CompanyList : UserControl
    {
        #region Constructor
        /// <summary>
        /// Creates a new instance of <see cref="CompanyList"/>.
        /// </summary>
        public CompanyList()
        {
            InitializeComponent();

            ViewModel = App.DIContainer.GetInstance<CompanyListViewModel>();
        }
        #endregion


        #region Props
        #region Dependency Props
        /// <summary>
        /// Registers the <see cref="ViewModel"/> property.
        /// </summary>
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(CompanyListViewModel), typeof(CompanyList), new PropertyMetadata(null));

        /// <summary>
        /// Registers the <see cref="SelectedCompany"/> property.
        /// </summary>
        protected static readonly DependencyProperty SelectedCompanyProperty =
            DependencyProperty.Register(nameof(SelectedCompany), typeof(Company), typeof(CompanyList), new PropertyMetadata(null, SelectedCompanyChanged));

        /// <summary>
        /// Registers the <see cref="SelectedCompanyId"/> property.
        /// </summary>
        public static readonly DependencyProperty SelectedCompanyIdProperty =
            DependencyProperty.Register(nameof(SelectedCompanyId), typeof(int), typeof(CompanyList), new PropertyMetadata(-1));
        #endregion


        /// <summary>
        /// Gets or sets the view model for the <see cref="CompanyList"/> user control.
        /// </summary>
        public CompanyListViewModel ViewModel
        {
            get { return (CompanyListViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        /// <summary>
        /// Gets or sets the selected <see cref="Company"/> item in the list.
        /// </summary>
        protected Company SelectedCompany
        {
            get { return (Company)GetValue(SelectedCompanyProperty); }
            set { SetValue(SelectedCompanyProperty, value); }
        }

        /// <summary>
        /// Gets or sets the selected company ID.
        /// </summary>
        public int SelectedCompanyId
        {
            get { return (int)GetValue(SelectedCompanyIdProperty); }
            set { SetValue(SelectedCompanyIdProperty, value); }
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Updates the <see cref="SelectedCompanyId"/> property value.
        /// </summary>
        private static void SelectedCompanyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ctrl = (CompanyList)d;

            if (ctrl == null)
                return;

            var selectedItem = (Company)e.NewValue;

            if (selectedItem == null)
                return;

            ctrl.SelectedCompanyId = selectedItem.CompanyID;
        }
        #endregion
    }
}
