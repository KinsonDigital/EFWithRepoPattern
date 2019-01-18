using EFWithRepoPattern.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EFWithRepoPattern.UserControls
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : UserControl
    {
        #region Constructors
        /// <summary>
        /// Creates a new instance of <see cref="EmployeeList"/>.
        /// </summary>
        public EmployeeList()
        {
            InitializeComponent();

            ViewModel = App.DIContainer.GetInstance<EmployeeListViewModel>();
        }
        #endregion


        #region Props
        #region Dependency Props
        /// <summary>
        /// Registers the <see cref="ViewModel"/> property.
        /// </summary>
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register(nameof(ViewModel), typeof(EmployeeListViewModel), typeof(EmployeeList), new PropertyMetadata(null));

        /// <summary>
        /// Registers the <see cref="CompanyId"/> property.
        /// </summary>
        public static readonly DependencyProperty CompanyIdProperty =
            DependencyProperty.Register(nameof(CompanyId), typeof(int), typeof(EmployeeList), new PropertyMetadata(-1, CompanyIdChanged));
        #endregion


        /// <summary>
        /// Gets or sets the view model.
        /// </summary>
        public EmployeeListViewModel ViewModel
        {
            get { return (EmployeeListViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }


        /// <summary>
        /// Gets or sets the ID of the company that all of the employees belong to.
        /// </summary>
        public int CompanyId
        {
            get { return (int)GetValue(CompanyIdProperty); }
            set { SetValue(CompanyIdProperty, value); }
        }
        #endregion


        #region Private Methods
        /// <summary>
        /// Update the <see cref="ViewModel"/>'s company ID value.
        /// </summary>
        private static void CompanyIdChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var ctrl = (EmployeeList)d;

            if (ctrl == null)
                return;

            //Update the company ID property on the viewmodel.  This will trigger pull of
            //employee data inside of the ViewModel
            ctrl.ViewModel.CompanyId = (int)e.NewValue;
        }
        #endregion
    }
}
