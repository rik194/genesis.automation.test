using Newtonsoft.Json;
using System.Collections.Generic;

namespace TopJSRepos.Models.WebApi.Responses
{
    public class RepositoriesResponse
    {
        [JsonProperty(PropertyName = "total_count")]
        public int TotalCount { get; set; }
        public IList<Repository> Items { get; set; }
    }
}
