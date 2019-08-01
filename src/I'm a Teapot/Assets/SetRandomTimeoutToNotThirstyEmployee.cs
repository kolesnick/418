using Entitas;
using UnityEngine;

namespace ImATeapot
{
    internal class SetRandomTimeoutToNotThirstyEmployee : IExecuteSystem
    {
        private readonly IGroup<GameEntity> employees;

        public SetRandomTimeoutToNotThirstyEmployee(GameContext game) =>
            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee)
                .NoneOf(GameMatcher.Thirsty, GameMatcher.Timeout));

        public void Execute()
        {
            foreach (var employee in employees.GetEntities())
                employee.AddTimeout(Random.Range(1f, 2f) * 60);
        }
    }
}
