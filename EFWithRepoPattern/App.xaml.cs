using EFWithRepoPattern.Data.Repositories;
using EFWithRepoPattern.Data.Repositories.DataContext;
using EFWithRepoPattern.ViewModels;
using SimpleInjector;
using System.Windows;

namespace EFWithRepoPattern
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Constructors
        /// <summary>
        /// Setups up all of the dependency injection for the purpose of practicing IoC(Inversion Of Control).
        /// </summary>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            DIContainer = new Container();

            DIContainer.Register<TestDBContext>();
            DIContainer.Register<CompanyRepository>();
            DIContainer.Register<CompanyListViewModel>();

            var mainWindow = new MainWindow();

            mainWindow.Show();
        }
        #endregion


        #region Props
        /// <summary>
        /// Gets the depenency injection container.
        /// </summary>
        public static Container DIContainer { get; private set; } = new Container();
        #endregion
    }
}
