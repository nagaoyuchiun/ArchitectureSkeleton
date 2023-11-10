using ArchitectureSkeleton.Fluent.Contract.Cell;

namespace ArchitectureSkeleton.Fluent.Contract
{
    public interface ISqlInsert<MainTable> : IParam, IAlias<MainTable>
    {
        ISqlInsert<MainTable> Columns(params string[] args);
    }
}
