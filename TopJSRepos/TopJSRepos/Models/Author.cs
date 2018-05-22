using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TopJSRepos.Models
{
    public class Author
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "login")]
        public string Username { get; set; }
        [JsonProperty(PropertyName = "avatar_url")]
        public string AvatarUrl { get; set; }
    }
}
