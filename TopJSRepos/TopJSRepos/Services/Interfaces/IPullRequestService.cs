using System.Collections.Generic;
using System.Threading.Tasks;
using TopJSRepos.Models;

namespace TopJSRepos.Services
{
    public interface IPullRequestService : IGenericService<PullRequest>
    {
        Task<IList<PullRequest>> GetItemsAsync(string username, string repoName);
    }
}
