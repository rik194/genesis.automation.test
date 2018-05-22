using CommonServiceLocator;

namespace TopJSRepos.ViewModels
{
    public class ViewModelLocator
    {
        public RepositoriesViewModel RepositoriesViewModel => 
            ServiceLocator.Current.GetInstance<RepositoriesViewModel>();
        public PullRequestsViewModel PullRequestsViewModel =>
            ServiceLocator.Current.GetInstance<PullRequestsViewModel>();
    }
}
