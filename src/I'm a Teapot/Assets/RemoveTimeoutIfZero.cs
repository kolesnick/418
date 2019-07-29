using Entitas;

namespace ImATeapot
{
    internal class RemoveTimeoutIfZero : IExecuteSystem
    {
        private readonly IGroup<GameEntity> timeouts;

        public RemoveTimeoutIfZero(GameContext game) =>
            timeouts = game.GetGroup(GameMatcher.Timeout);

        public void Execute()
        {
            foreach (var entity in timeouts.GetEntities())
                if (entity.timeout.value <= 0)
                    entity.RemoveTimeout();
        }
    }
}
