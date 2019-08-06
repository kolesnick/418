using Entitas;

namespace ImATeapot.Systems
{
    internal class MakeEmployeeThirstyIfNoTimeout : IExecuteSystem
    {
        private readonly IGroup<GameEntity> employees;

        public MakeEmployeeThirstyIfNoTimeout(GameContext game) =>
            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee)
                .NoneOf(GameMatcher.Timeout, GameMatcher.Thirsty));

        public void Execute()
        {
            foreach (var employee in employees.GetEntities())
                employee.isThirsty = true;
        }
    }
}
