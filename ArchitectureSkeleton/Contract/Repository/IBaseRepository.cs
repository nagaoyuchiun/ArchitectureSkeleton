using System.Threading.Tasks;

namespace ArchitectureSkeleton.Contract.Repository
{
    public interface IBaseRepository<T> : ISync<T>, IAsync<T>, ITransaction where T : class
    {
    }
}
