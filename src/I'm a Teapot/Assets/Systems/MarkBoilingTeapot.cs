using Entitas;

namespace ImATeapot.Systems
{
    internal class MarkBoilingTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;

        public MarkBoilingTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Temperature, GameMatcher.Heating));

        public void Execute()
        {
            foreach (var teapot in teapots)
                teapot.isBoiling = teapot.temperature.value >= 100;
        }
    }
}
