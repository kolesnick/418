using Entitas;

namespace ImATeapot.Systems
{
    internal class MarkFullTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;

        public MarkFullTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher.AllOf(GameMatcher.Teapot, GameMatcher.Amount, GameMatcher.Capacity));

        public void Execute()
        {
            foreach (var teapot in teapots)
                teapot.isFull = teapot.amount.value >= teapot.capacity.value;
        }
    }
}
