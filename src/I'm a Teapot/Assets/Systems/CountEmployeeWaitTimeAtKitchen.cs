using Entitas;
using UnityEngine;

namespace ImATeapot.Systems
{
    internal class CountEmployeeWaitTimeAtKitchen : IExecuteSystem
    {
        private static float DeltaTime => Time.deltaTime;

        private readonly IGroup<GameEntity> employeesAtKitchen;
        private readonly StatisticsContext statistics;

        public CountEmployeeWaitTimeAtKitchen(GameContext game, StatisticsContext statistics)
        {
            employeesAtKitchen = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee, GameMatcher.AtKitchen));

            this.statistics = statistics;
        }

        public void Execute()
        {
            foreach (var employee in employeesAtKitchen)
            {
                float currentTime =
                    statistics.hasCumulativeWaitTime
                        ? statistics.cumulativeWaitTime.value
                        : 0;

                statistics.ReplaceCumulativeWaitTime(currentTime + DeltaTime);
            }
        }
    }
}
