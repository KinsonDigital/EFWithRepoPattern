using EFWithRepoPattern.ViewModels;
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
        #endregion


        /// <summary>
        /// Gets or sets the view model for the <see cref="CompanyList"/> user control.
        /// </summary>
        public CompanyListViewModel ViewModel
        {
            get { return (CompanyListViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
        #endregion
    }
}
