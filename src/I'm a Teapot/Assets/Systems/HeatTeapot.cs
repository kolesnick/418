using Entitas;
using UnityEngine;

namespace ImATeapot.Systems
{
    internal class HeatTeapot : IExecuteSystem
    {
        private static float DeltaTime => Time.deltaTime;

        private const float HeatSpeed = 100f / 5 * 6; // 6 cups in 5 minutes from 0 to 100

        private readonly IGroup<GameEntity> teapots;

        public HeatTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Heating, GameMatcher.Amount, GameMatcher.Temperature));

        public void Execute()
        {
            foreach (var teapot in teapots)
            {
                float temperatureIncrease = DeltaTime * HeatSpeed / teapot.amount.value;

                teapot.ReplaceTemperature(teapot.temperature.value + temperatureIncrease);
            }
        }
    }
}
