using System.Linq;
using Entitas;

namespace ImATeapot.Systems
{
    internal class StartFillingEmptyTeapotIfThirstyAndNoFilledTeapots : IExecuteSystem
    {
        private readonly IGroup<GameEntity> emptyTeapots;
        private readonly IGroup<GameEntity> filledTeapots;
        private readonly IGroup<GameEntity> fillingTeapots;
        private readonly IGroup<GameEntity> employees;

        public StartFillingEmptyTeapotIfThirstyAndNoFilledTeapots(GameContext game)
        {
            emptyTeapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Empty)
                .NoneOf(GameMatcher.BeingFilled));

            filledTeapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot)
                .NoneOf(GameMatcher.Empty));

            fillingTeapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.BeingFilled));

            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee, GameMatcher.Thirsty, GameMatcher.AtKitchen)
                .NoneOf(GameMatcher.FillingTeapot));
        }

        public void Execute()
        {
            foreach (var (teapot, employee) in (emptyTeapots, employees).Zip().ToList())
                if (filledTeapots.count == 0 && fillingTeapots.count == 0)
                {
                    employee.isFillingTeapot = true;
                    teapot.isBeingFilled = true;
                }
        }
    }
}
