using Newtonsoft.Json;
using System.Collections.Generic;

namespace TopJSRepos.Models
{
    public class Repository : BaseModel
    {
        [JsonProperty(PropertyName = "forks_count")]
        public int ForksCount { get; set; }
        [JsonProperty(PropertyName = "stargazers_count")]
        public int StarsCount { get; set; }
    }
}
