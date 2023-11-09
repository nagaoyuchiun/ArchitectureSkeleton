using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface ISqlInsert<MainTable> : IParam, IAlias<MainTable>
    {
        ISqlInsert<MainTable> Columns(params string[] args);
    }
}
