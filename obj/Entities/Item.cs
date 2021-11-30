namespace Catalog.Entities
{
    // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records
    public record Item 
    {
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/init
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreateDate { get; init; } 
    }
}