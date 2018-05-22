using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TopJSRepos.Models;

namespace TopJSRepos.Services
{
    public interface IGenericService<MODEL> where MODEL: BaseModel
    {
        Task<IList<MODEL>> GetItemsAsync();
    }
}
