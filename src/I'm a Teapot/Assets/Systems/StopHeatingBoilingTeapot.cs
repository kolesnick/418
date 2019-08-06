using Entitas;

namespace ImATeapot.Systems
{
    internal class StopHeatingBoilingTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;

        public StopHeatingBoilingTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Boiling, GameMatcher.Heating));

        public void Execute()
        {
            foreach (var teapot in teapots.GetEntities())
                teapot.isHeating = false;
        }
    }
}
