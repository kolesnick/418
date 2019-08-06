using Entitas;

namespace ImATeapot.Systems
{
    internal class GetNotThirstyEmployeeBackToWork : IExecuteSystem
    {
        private readonly IGroup<GameEntity> employees;

        public GetNotThirstyEmployeeBackToWork(GameContext game) =>
            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee)
                .NoneOf(GameMatcher.Thirsty));

        public void Execute()
        {
            foreach (var employee in employees)
            {
                employee.isAtKitchen = false;
                employee.isWorking = true;
            }
        }
    }
}
