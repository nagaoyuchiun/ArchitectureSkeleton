using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface IInsert<MainTable> : IParam
    {
        IInsert<MainTable> Columns(params string[] args);
    }
}
