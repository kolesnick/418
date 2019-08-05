using Entitas;
using UnityEngine;

namespace ImATeapot
{
    internal class ApplyTimeScale : IExecuteSystem
    {
        private static float TimeScale { get => Time.timeScale; set => Time.timeScale = value; }

        private readonly SettingsContext settings;

        public ApplyTimeScale(SettingsContext settings) => this.settings = settings;

        public void Execute()
        {
            if (TimeScale != settings.timeScale.value)
                TimeScale = settings.timeScale.value;
        }
    }
}
