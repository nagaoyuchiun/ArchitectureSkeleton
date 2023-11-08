using System.Threading.Tasks;

namespace ArchitectureSkeleton.Contract.Repository
{
    public interface ICommandRepository<T> : IGetAll<T>, IGet<T>, IInsert<T>, IUpdate<T>, IDelete<T>, ITransaction where T : class
    {
    }
}
