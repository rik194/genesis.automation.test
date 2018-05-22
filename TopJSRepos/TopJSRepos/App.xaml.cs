using System;
using Xamarin.Forms;
using TopJSRepos.Views;
using Xamarin.Forms.Xaml;
using TopJSRepos.Config;
using TopJSRepos.Services.Navigator;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TopJSRepos
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();
            //SimpleIoc.Default.Register<INavigationService>(() => nav);
            new UnityConfig();
            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
