using System.Threading.Tasks;

namespace App.Common
{
    public interface ICreateRequestHandler<T>
    {
        Task<T> Execute(T model);
    }
}