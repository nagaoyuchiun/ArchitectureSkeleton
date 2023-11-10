using ArchitectureSkeleton.SqlBulid.Contract.Cell;

namespace ArchitectureSkeleton.SqlBulid.Contract
{
    public interface ISqlUpdate<MainTable> : IConditional<MainTable>, IAlias<MainTable>
    {
        ISqlUpdate<MainTable> Set(string arg);
    }
}
