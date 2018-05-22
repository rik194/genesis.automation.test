using System.Collections.Generic;
using System.Threading.Tasks;
using TopJSRepos.Models;

namespace TopJSRepos.Services
{
    public interface IRepositoryService : IGenericService<Repository>
    {
        Task<Repository> GetItemAsync(string id);
        IList<Repository> FilterByUsername(IList<Repository> repositories, string username);
        IList<Repository> FilterByName(IList<Repository> repositories, string name);
    }
}
