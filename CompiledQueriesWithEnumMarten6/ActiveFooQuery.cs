using System.Linq.Expressions;
using Marten;
using Marten.Linq;

namespace CompiledQueriesWithEnumMarten6;

public class ActiveFooQuery : ICompiledListQuery<Foo>, IQueryPlanning
{
    public string Name { get; set; }
    public ActiveFooQuery()
    {

    }

    public ActiveFooQuery(string name)
    {
        Name = name;
    }

    public Expression<Func<IMartenQueryable<Foo>, IEnumerable<Foo>>> QueryIs() =>
        q => q.Where(x => x.Status.In(StatusEnum.Active) && x.Name == Name);

    public void SetUniqueValuesForQueryPlanning()
    {
        Name = "ActiveFooQuery";
    }
}
