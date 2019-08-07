using Entitas;
using UnityEngine;

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
                employee.isWorking = true;
                employee.AddTimeout(Random.Range(0f, 2f) * 60);
            }
        }
    }
}
