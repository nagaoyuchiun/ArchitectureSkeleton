using ArchitectureSkeleton.Fluent.Contract.Cell;

namespace ArchitectureSkeleton.Fluent.Contract
{
    public interface ISqlUpdate<MainTable> : IConditional<MainTable>, IAlias<MainTable>
    {
        ISqlUpdate<MainTable> Set(string arg);
    }
}
