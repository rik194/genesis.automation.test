using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TopJSRepos.Models;
using TopJSRepos.Models.WebApi.Responses;

namespace TopJSRepos.Services
{
    public class RepositoryService : IRepositoryService
    {
        HttpClient client;

        public IList<Repository> FilterByName(IList<Repository> repositories, string name)
        {
            return repositories.Where(x => name.Equals(x.Name)).ToList();
        }

        public IList<Repository> FilterByUsername(IList<Repository> repositories, string username)
        {
            return repositories.Where(x => username.Equals(x.Owner.Username)).ToList();
        }

        public Task<Repository> GetItemAsync(string id) => throw new NotImplementedException();

        public async Task<IList<Repository>> GetItemsAsync()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Config.Config.BASE_URL);
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "http://developer.github.com/v3/#user-agent-required");
            var result = await client.GetAsync("/search/repositories?q=language:JavaScript&sort=stars&page=1");
            if (result.IsSuccessStatusCode && result.StatusCode == HttpStatusCode.OK)
            {
                var json = await result.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<RepositoriesResponse>(json);
                return response.Items;
            }
            else
            {
                return null;
            }
        }
    }
}
