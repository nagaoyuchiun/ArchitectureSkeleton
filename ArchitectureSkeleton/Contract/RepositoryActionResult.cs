namespace ArchitectureSkeleton.Contract
{
    public class RepositoryActionResult<T>
    {
        public required T DataBefore { get; set; }
        public required T DataAfter { get; set; }
    }
}
