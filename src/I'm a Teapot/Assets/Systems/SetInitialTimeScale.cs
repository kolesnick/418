using Entitas;

namespace ImATeapot.Systems
{
    internal class SetInitialTimeScale : IInitializeSystem
    {
        private readonly SettingsContext settings;
        private readonly int timeScale;

        public SetInitialTimeScale(SettingsContext settings, int timeScale)
        {
            this.settings = settings;
            this.timeScale = timeScale;
        }

        public void Initialize() =>
            settings.SetTimeScale(timeScale);
    }
}
