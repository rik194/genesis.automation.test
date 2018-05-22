using CommonServiceLocator;
using TopJSRepos.Services;
using TopJSRepos.ViewModels;
using Unity;
using Unity.ServiceLocation;

namespace TopJSRepos.Config
{
    public class UnityConfig
    {
        public UnityConfig()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IRepositoryService, RepositoryService>();
            unityContainer.RegisterType<IPullRequestService, PullRequestService>();
            // ViewModels
            unityContainer.RegisterInstance(typeof(RepositoriesViewModel));
            unityContainer.RegisterInstance(typeof(PullRequestsViewModel));
            // Service Locator
            var unityServiceLocator = new UnityServiceLocator(unityContainer);
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);
        }
    }
}
