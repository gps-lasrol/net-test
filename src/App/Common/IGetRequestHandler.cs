using System;
using System.Threading.Tasks;

namespace App.Common
{
    public interface IGetRequestHandler<T>
    {
        Task<T> Execute(Guid id);
    }
}