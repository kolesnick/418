using Entitas;
using UnityEngine;

namespace ImATeapot.Systems
{
    internal class ReduceTimeout : IExecuteSystem
    {
        private static float DeltaTime => Time.deltaTime;

        private readonly IGroup<GameEntity> timeouts;

        public ReduceTimeout(GameContext game) =>
            timeouts = game.GetGroup(GameMatcher.Timeout);

        public void Execute()
        {
            foreach (var entity in timeouts)
                entity.ReplaceTimeout(entity.timeout.value - DeltaTime);
        }
    }
}
