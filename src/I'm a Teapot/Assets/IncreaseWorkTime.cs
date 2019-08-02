using Entitas;
using UnityEngine;

namespace ImATeapot
{
    internal class IncreaseWorkTime : IExecuteSystem
    {
        private static float DeltaTime => Time.deltaTime;

        private readonly StatisticsContext statistics;

        public IncreaseWorkTime(StatisticsContext statistics) =>
            this.statistics = statistics;

        public void Execute()
        {
            float currentTime =
                statistics.hasWorkTime
                    ? statistics.workTime.value
                    : 0;

            statistics.ReplaceWorkTime(currentTime + DeltaTime);
        }
    }
}
