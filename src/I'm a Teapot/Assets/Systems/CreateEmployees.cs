using Entitas;

namespace ImATeapot.Systems
{
    internal class CreateEmployees : IInitializeSystem
    {
        private readonly GameContext game;
        private readonly int employeeCount;

        public CreateEmployees(GameContext game, int count)
        {
            this.game = game;
            employeeCount = count;
        }

        public void Initialize()
        {
            for (int index = 0; index < employeeCount; index++)
            {
                var employee = game.CreateEntity();
                employee.isEmployee = true;
            }
        }
    }
}
