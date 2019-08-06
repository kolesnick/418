using Entitas;

namespace ImATeapot.Systems
{
    internal class MarkFullTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;

        public MarkFullTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Amount, GameMatcher.Capacity));

        public void Execute()
        {
            foreach (var teapot in teapots)
                teapot.isFull = teapot.amount.value >= teapot.capacity.value;
        }
    }
    internal class MarkHotTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;

        public MarkHotTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Temperature));

        public void Execute()
        {
            foreach (var teapot in teapots)
                teapot.isHot = teapot.temperature.value >= 90;
        }
    }
}
