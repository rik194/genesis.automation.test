using System;

namespace TopJSRepos.Models
{
    public class PullRequest : BaseModel
    {
        public string Body { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public enum Status
        {
            Open,
            Closed
        }
    }
}
