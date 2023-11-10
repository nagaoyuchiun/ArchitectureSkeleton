using ArchitectureSkeleton.SqlBulid.Contract.Cell;

namespace ArchitectureSkeleton.SqlBulid.Contract
{
    public interface ISqlDelete<MainTable> : IConditional<MainTable>, IAlias<MainTable>
    {
        ISqlDelete<MainTable> Target(string arg);
    }
}
