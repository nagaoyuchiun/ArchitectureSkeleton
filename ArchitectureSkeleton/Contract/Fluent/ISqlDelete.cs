using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface ISqlDelete<MainTable> : IConditional<MainTable>, IAlias<MainTable>
    {
        ISqlDelete<MainTable> Target(string arg);
    }
}
