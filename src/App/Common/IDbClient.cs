using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Common
{
    public interface IDbClient<T>
    {
        IList<T> Database { get; }
        Task<IEnumerable<T>> Get();
        Task<T> Get(Guid id);
        Task<T> Create(T model);
        Task<T> Delete();
    }
}