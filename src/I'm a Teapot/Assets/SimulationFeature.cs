﻿namespace ImATeapot
{
    internal class SimulationFeature : Feature
    {
        public SimulationFeature(GameContext game)
        {
            Add(new CreateEmployees(game, count: 10));

            Add(new SetRandomTimeoutToNotThirstyEmployee(game));

            Add(new ReduceTimeout(game));
            Add(new RemoveTimeoutIfZero(game));

            Add(new MakeEmployeeThirstyIfNoTimeout(game));
        }
    }
}
