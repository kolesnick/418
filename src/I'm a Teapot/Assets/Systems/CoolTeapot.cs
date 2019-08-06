using Entitas;
using UnityEngine;

namespace ImATeapot.Systems
{
    internal class CoolTeapot : IExecuteSystem
    {
        private static float DeltaTime => Time.deltaTime;

        private const float CoolSpeed = 1; // 1 degree per 1 minute

        private readonly IGroup<GameEntity> teapots;

        public CoolTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.Temperature)
                .NoneOf(GameMatcher.Heating));

        public void Execute()
        {
            foreach (var teapot in teapots)
            {
                float temperatureDecrease = DeltaTime * CoolSpeed;

                teapot.ReplaceTemperature(teapot.temperature.value - temperatureDecrease);

                if (teapot.temperature.value < 0)
                    teapot.ReplaceTemperature(0);
            }
        }
    }
}
