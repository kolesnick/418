namespace ImATeapot.Systems
{
    internal class SimulationFeature : Feature
    {
        public SimulationFeature(GameContext game, SettingsContext settings, StatisticsContext statistics)
        {
            Add(new SetInitialTimeScale(settings, timeScale: 1));
            Add(new ApplyTimeScale(settings));

            Add(new CreateTeapots(game, count: 2));
            Add(new CreateEmployees(game, count: 10));

            Add(new SetRandomTimeoutToNotThirstyEmployee(game));

            Add(new ReduceTimeout(game));
            Add(new RemoveTimeoutIfZero(game));

            Add(new MakeEmployeeThirstyIfNoTimeout(game));

            Add(new GetThirstyEmployeeToKitchen(game));
            Add(new GetNotThirstyEmployeeBackToWork(game));

            Add(new IncreaseWorkTime(statistics));
            Add(new CountEmployeeWaitTimeAtKitchen(game, statistics));
        }
    }
}
