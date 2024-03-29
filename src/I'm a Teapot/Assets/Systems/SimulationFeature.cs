﻿using System.Collections.Generic;
using System.Linq;

namespace ImATeapot.Systems
{
    internal class SimulationFeature : Feature
    {
        public SimulationFeature(GameContext game, SettingsContext settings, StatisticsContext statistics)
        {
            Add(new SetInitialTimeScale(settings, timeScale: 1));
            Add(new CorrectTooSmallTimeScale(settings));
            Add(new ApplyTimeScale(settings));

            Add(new CreateTeapots(game, count: 2));
            Add(new CreateEmployees(game, count: 40));

            Add(new MarkEmptyTeapot(game));
            Add(new MarkFullTeapot(game));
            Add(new MarkHotTeapot(game));
            Add(new MarkBoilingTeapot(game));

            Add(new SetRandomTimeoutToNotThirstyEmployee(game));

            Add(new ReduceTimeout(game));
            Add(new RemoveTimeoutIfZero(game));

            Add(new MakeEmployeeThirstyIfNoTimeout(game));

            Add(new GetThirstyEmployeeToKitchen(game));
            Add(new DrinkHotTea(game));
            Add(new GetNotThirstyEmployeeBackToWork(game));

            Add(new FillTeapot(game));
            Add(new HeatTeapot(game));

            Add(new StartFillingEmptyTeapotIfThirstyAndNoFilledTeapots(game));
            Add(new StopFillingFullTeapot(game));

            Add(new StartHeatingNotHotTeapot(game));
            Add(new StopHeatingBoilingTeapot(game));

            Add(new CoolTeapot(game));

            Add(new IncreaseWorkTime(statistics));
            Add(new CountEmployeeWaitTimeAtKitchen(game, statistics));
        }
    }
}
