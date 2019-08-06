using Entitas;

namespace ImATeapot.Systems
{
    internal class StopFillingFullTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;
        private readonly IGroup<GameEntity> employees;

        public StopFillingFullTeapot(GameContext game)
        {
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Full, GameMatcher.BeingFilled));

            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee, GameMatcher.FillingTeapot));
        }

        public void Execute()
        {
            foreach (var (teapot, employee) in (teapots, employees).Zip())
            {
                employee.isFillingTeapot = false;
                teapot.isBeingFilled = false;
            }
        }
    }
}
