using Entitas;

namespace ImATeapot.Systems
{
    internal class CorrectTooSmallTimeScale : IExecuteSystem
    {
        private const float MinTimeScale = 0.001f;

        private readonly SettingsContext settings;

        public CorrectTooSmallTimeScale(SettingsContext settings) => this.settings = settings;

        public void Execute()
        {
            if (settings.timeScale.value < MinTimeScale)
                settings.ReplaceTimeScale(MinTimeScale);
        }
    }
}
