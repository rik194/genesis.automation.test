using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TopJSRepos.Models;

namespace TopJSRepos.Services
{
    public class PullRequestService : IPullRequestService
    {
        HttpClient client;

        public async Task<IList<PullRequest>> GetItemsAsync(string username, string repoName)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(Config.Config.BASE_URL);
            client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "http://developer.github.com/v3/#user-agent-required");
            var result = await client.GetAsync(String.Format("/repos/{0}/{1}/pulls?", username, repoName));
            if (result.IsSuccessStatusCode && result.StatusCode == HttpStatusCode.OK)
            {
                var json = await result.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<IList<PullRequest>>(json);
                return response;
            }
            else
            {
                return null;
            }
        }

        public Task<IList<PullRequest>> GetItemsAsync() =>
            throw new NotImplementedException();
    }
}
