using Entitas;

namespace ImATeapot.Systems
{
    internal class StartFillingEmptyTeapotIfThirsty : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;
        private readonly IGroup<GameEntity> employees;

        public StartFillingEmptyTeapotIfThirsty(GameContext game)
        {
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Empty)
                .NoneOf(GameMatcher.BeingFilled));

            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee, GameMatcher.Thirsty, GameMatcher.AtKitchen)
                .NoneOf(GameMatcher.FillingTeapot));
        }

        public void Execute()
        {
            foreach (var (teapot, employee) in (teapots, employees).Zip())
            {
                employee.isFillingTeapot = true;
                teapot.isBeingFilled = true;
            }
        }
    }
}
