using Entitas;
using UnityEngine;

namespace ImATeapot.Systems
{
    internal class FillTeapot : IExecuteSystem
    {
        private static float DeltaTime => Time.deltaTime;

        private const float FillSpeed = 6f / 0.5f; // 6 cups in half a minute

        private readonly IGroup<GameEntity> teapots;

        public FillTeapot(GameContext game) =>
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot, GameMatcher.BeingFilled, GameMatcher.Temperature));

        public void Execute()
        {
            foreach (var teapot in teapots)
            {
                float initialAmount = teapot.amount.value;
                float addedAmount = DeltaTime * FillSpeed;

                float initialTemperature = teapot.temperature.value;
                float addedTemperature = 0;

                float newAmount = initialAmount + addedAmount;
                float newTemperature =
                    (initialTemperature * initialAmount + addedTemperature * addedAmount)
                    / (initialAmount + addedAmount);

                teapot.ReplaceAmount(newAmount);
                teapot.ReplaceTemperature(newTemperature);

                if (teapot.amount.value > teapot.capacity.value)
                    teapot.ReplaceAmount(teapot.capacity.value);
            }
        }
    }
}
