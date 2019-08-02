using Entitas;

namespace ImATeapot {
    internal class CreateTeapots : IInitializeSystem
    {
        private readonly GameContext game;
        private readonly int teapotCount;

        public CreateTeapots(GameContext game, int count)
        {
            this.game = game;
            teapotCount = count;
        }

        public void Initialize()
        {
            for (int index = 0; index < teapotCount; index++)
            {
                var employee = game.CreateEntity();
                employee.isTeapot = true;
            }
        }
    }
}