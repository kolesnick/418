using System.Linq;

public sealed partial class StatisticsEntity
{
    public override string ToString() =>
        GetComponents()
            .Select(x => x.ToString())
            .Aggregate("", (x, y) => x == "" ? y : $"{x} | {y}");
}
