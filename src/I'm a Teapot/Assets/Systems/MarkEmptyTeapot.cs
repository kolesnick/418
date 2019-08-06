using Entitas;

namespace ImATeapot.Systems
{
    internal class MarkEmptyTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;

        public MarkEmptyTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher.AllOf(GameMatcher.Teapot, GameMatcher.Amount));

        public void Execute()
        {
            foreach (var teapot in teapots)
                teapot.isEmpty = teapot.amount.value < 1;
        }
    }
}
