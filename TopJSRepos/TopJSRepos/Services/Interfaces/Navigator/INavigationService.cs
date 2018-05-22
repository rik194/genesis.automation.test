using System;
using Xamarin.Forms;

namespace TopJSRepos.Services.Navigator
{
    public interface INavigationService
    {
        void GoBack();
        void NavigateTo(string pageKey);
        void NavigateTo(string pageKey, object parameter);
        void Configure(string pageKey, Type pageType);
        void Initialize(NavigationPage navigation);
    }
}