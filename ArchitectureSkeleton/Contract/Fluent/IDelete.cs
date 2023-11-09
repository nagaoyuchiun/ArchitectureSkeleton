using ArchitectureSkeleton.Contract.Fluent.Cell;

namespace ArchitectureSkeleton.Contract.Fluent
{
    public interface IDelete<MainTable> : IConditional<MainTable
    {
        IDelete<MainTable> Target(string arg);
    }
}
