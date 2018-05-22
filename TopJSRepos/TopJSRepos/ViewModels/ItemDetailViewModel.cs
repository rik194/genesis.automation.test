using TopJSRepos.Models.Menu;

namespace TopJSRepos.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public MenuItem Item { get; set; }
        public ItemDetailViewModel(MenuItem item = null)
        {
            Title = item?.Title;
            Item = item;
        }
    }
}
