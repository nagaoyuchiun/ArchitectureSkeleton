using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface IInsert<MainTable> : IParam, IAlias<MainTable>
    {
        IInsert<MainTable> Columns(params string[] args);
    }
}
