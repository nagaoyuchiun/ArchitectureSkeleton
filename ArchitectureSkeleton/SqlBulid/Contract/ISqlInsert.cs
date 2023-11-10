using ArchitectureSkeleton.SqlBulid.Contract.Cell;

namespace ArchitectureSkeleton.SqlBulid.Contract
{
    public interface ISqlInsert<MainTable> : IParam, IAlias<MainTable>
    {
        ISqlInsert<MainTable> Columns(params string[] args);
    }
}
