using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Common
{
    public interface IGetAllRequestHandler<T>
    {
        Task<IEnumerable<T>> Execute();
    }
}