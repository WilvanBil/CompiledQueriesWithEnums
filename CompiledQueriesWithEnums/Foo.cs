namespace CompiledQueriesWithEnums;

public class Foo
{
    public Guid Id { get; set; }
    public StatusEnum Status { get; set; }
    public string Name { get; set; }
}

public enum StatusEnum
{
    Active,
    Inactive
}
