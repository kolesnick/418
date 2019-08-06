using System.Linq;

public sealed partial class GameEntity
{
    public override string ToString() =>
        isTeapot
            ? FormatTeapot()
            : isEmployee
                ? $"{nameof(Employee)} [ {FormatComponentsExcept(nameof(Employee))} ]"
                : base.ToString();

    private string FormatTeapot() =>
        hasAmount && hasCapacity
            ? $"{nameof(Teapot)} {FormatTeapotAmountAndCapacity()} [ {FormatComponentsExcept(nameof(Teapot), nameof(Amount), nameof(Capacity))} ]"
            : $"{nameof(Teapot)} [ {FormatComponentsExcept(nameof(Teapot))} ]";

    private string FormatTeapotAmountAndCapacity() =>
        string.Join(
            "",
            Enumerable
                .Range(1, (int) capacity.value)
                .Select(cupNumber => cupNumber <= amount.value ? "█" : "░"));

    private string FormatComponentsExcept(params string[] components) =>
        GetComponents()
            .Select(x => x.ToString())
            .Except(components)
            .Aggregate("", (x, y) => x == "" ? y : $"{x}, {y}");
}
