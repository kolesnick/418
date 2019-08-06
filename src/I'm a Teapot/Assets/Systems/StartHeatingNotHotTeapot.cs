using Entitas;

namespace ImATeapot.Systems
{
    internal class StartHeatingNotHotTeapot : IExecuteSystem
    {
        private readonly IGroup<GameEntity> teapots;
        private readonly IGroup<GameEntity> employees;

        public StartHeatingNotHotTeapot(GameContext game)
        {
            teapots = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Teapot)
                .NoneOf(GameMatcher.Hot, GameMatcher.Empty, GameMatcher.BeingFilled, GameMatcher.Heating));

            employees = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Employee, GameMatcher.AtKitchen));
        }

        public void Execute()
        {
            foreach (var teapot in teapots.GetEntities())
                if (employees.count > 0)
                    teapot.isHeating = true;
        }
    }
}
