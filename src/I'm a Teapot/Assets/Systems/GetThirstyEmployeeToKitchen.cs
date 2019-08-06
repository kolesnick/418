using Entitas;

namespace ImATeapot.Systems
{
    internal class GetThirstyEmployeeToKitchen : IExecuteSystem
    {
        private readonly IGroup<GameEntity> employees;

        public GetThirstyEmployeeToKitchen(GameContext game) =>
            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee, GameMatcher.Thirsty));

        public void Execute()
        {
            foreach (var employee in employees)
            {
                employee.isWorking = false;
                employee.isAtKitchen = true;
            }
        }
    }
}
