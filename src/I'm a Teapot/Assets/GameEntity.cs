using System.Linq;

public sealed partial class GameEntity
{
    public override string ToString() =>
        isEmployee
            ? $"{nameof(Employee)} [ {FormatComponentsExcept(nameof(Employee))} ]"
            : base.ToString();

    private string FormatComponentsExcept(string component) =>
        GetComponents()
            .Select(x => x.ToString())
            .Except(new [] { component })
            .Aggregate("", (x, y) => x == "" ? y : $"{x}, {y}");
}
