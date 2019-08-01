public sealed partial class GameEntity
{
    public override string ToString() =>
        isEmployee
            ? $"Employee :: {base.ToString()}"
            : base.ToString();
}
