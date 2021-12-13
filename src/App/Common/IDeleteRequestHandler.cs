using System;
using System.Threading.Tasks;

namespace App.Common
{
    public interface IDeleteRequestHandler<T>
    {
        Task<T> Execute(Guid id);
    }
}