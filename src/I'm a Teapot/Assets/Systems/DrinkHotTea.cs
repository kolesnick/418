using System;
using Entitas;

namespace ImATeapot.Systems
{
    internal class DrinkHotTea : IExecuteSystem
    {
        private readonly IGroup<GameEntity> employees;
        private readonly IGroup<GameEntity> teapots;

        public DrinkHotTea(GameContext game)
        {
            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee, GameMatcher.Thirsty, GameMatcher.AtKitchen));

            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Hot)
                .NoneOf(GameMatcher.Empty));
        }

        public void Execute()
        {
            foreach (var employee in employees)
            foreach (var teapot in teapots)
            {
                teapot.ReplaceAmount(teapot.amount.value - 1);

                employee.isThirsty = false;

                return; // one cup at a time
            }
        }
    }
}
