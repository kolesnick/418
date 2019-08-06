using ImATeapot.Systems;
using UnityEngine;

namespace ImATeapot
{
    public class Bootstrap : MonoBehaviour
    {
        private Entitas.Systems systems;

        private void Awake() =>
            systems =
                new SimulationFeature(
                    Contexts.sharedInstance.game,
                    Contexts.sharedInstance.settings,
                    Contexts.sharedInstance.statistics);

        private void Start() => systems.Initialize();

        private void Update()
        {
            systems.Execute();
            systems.Cleanup();
        }

        private void OnDestroy() => systems.Cleanup();
    }
}
