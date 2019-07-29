using System;

namespace ImATeapot
{
    internal class SimulationFeature : Feature
    {
        public SimulationFeature(GameContext game)
        {
            Add(new ReduceTimeout(game));
            Add(new RemoveTimeoutIfZero(game));
        }
    }
}
