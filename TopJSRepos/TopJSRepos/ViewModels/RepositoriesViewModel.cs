using System.Collections.Generic;
using System.ComponentModel;
using TopJSRepos.Models;
using TopJSRepos.Services;

namespace TopJSRepos.ViewModels
{
    public class RepositoriesViewModel : BaseViewModel
    {
        private readonly IRepositoryService repositoryService;

        public RepositoriesViewModel(IRepositoryService repositoryService) {
            this.repositoryService = repositoryService;
            GetRepositories();
        }

        private IList<Repository> _Repositories;
        public IList<Repository> Repositories {
            get { return _Repositories; }
            set { _Repositories = value; OnPropertyChanged(nameof(Repositories)); }
        }

        private async void GetRepositories()
        {
            Repositories = await repositoryService.GetItemsAsync();
        }
    }
}
