using Entitas;

namespace ImATeapot.Systems
{
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
                var teapot = game.CreateEntity();
                teapot.isTeapot = true;
                teapot.AddTemperature(0);
                teapot.AddCapacity(6);
                teapot.AddAmount(0);
            }
        }
    }
}
