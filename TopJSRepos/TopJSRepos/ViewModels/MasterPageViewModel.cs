using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TopJSRepos.Models;
using TopJSRepos.Views;

namespace TopJSRepos.ViewModels
{
    class MasterPageViewModel : BaseViewModel
    {
        public ObservableCollection<MasterDetailPageMenuItem> MenuItems { get; set; }

        public MasterPageViewModel()
        {
            Title = "Top JS Repositories";

            MenuItems = new ObservableCollection<MasterDetailPageMenuItem>(new[]
            {
                    new MasterDetailPageMenuItem { Id = 0, Title = "Repositories", TargetType  = typeof(RepositoriesPage) },
                    new MasterDetailPageMenuItem { Id = 1, Title = "About", TargetType  = typeof(AboutPage) }
            });
        }
    }
}
