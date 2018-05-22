using CommonServiceLocator;
using TopJSRepos.Services;
using TopJSRepos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopJSRepos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RepositoriesPage : ContentPage
    {
        public RepositoriesPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(RepositoriesViewModel));
        }
    }
}