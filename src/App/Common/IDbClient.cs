using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Common
{
    public interface IDbClient<TKey, TModel>
    {
        IDictionary<TKey, TModel> Database { get; }
        Task<IEnumerable<TModel>> Get();
        Task<TModel?> Get(Guid id);
        Task<TModel> Create(TModel model);
        Task<TModel> Delete(Guid id);
    }
}