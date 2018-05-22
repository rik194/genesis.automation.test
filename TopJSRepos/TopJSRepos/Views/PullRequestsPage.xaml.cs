using CommonServiceLocator;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using TopJSRepos.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopJSRepos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PullRequestsPage : ContentPage
    {

        public PullRequestsPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(PullRequestsViewModel));
        }
    }
}
