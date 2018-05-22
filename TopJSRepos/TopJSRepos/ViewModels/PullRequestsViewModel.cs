using System;
using System.Collections.Generic;
using System.Text;
using TopJSRepos.Models;
using TopJSRepos.Services;

namespace TopJSRepos.ViewModels
{
    public class PullRequestsViewModel : BaseViewModel
    {
        private readonly IPullRequestService pullRequestService;

        public PullRequestsViewModel(IPullRequestService pullRequestService)
        {
            this.pullRequestService = pullRequestService;
            GetPullRequests("facebook", "react");
        }

        private IList<PullRequest> _PullRequest;
        public IList<PullRequest> PullRequest
        {
            get { return _PullRequest; }
            set { _PullRequest = value; OnPropertyChanged(nameof(PullRequest)); }
        }

        private async void GetPullRequests(string username, string repoName)
        {
            PullRequest = await pullRequestService.GetItemsAsync(username, repoName);
        }
    }
}
