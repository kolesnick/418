//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Capacity capacity { get { return (Capacity)GetComponent(GameComponentsLookup.Capacity); } }
    public bool hasCapacity { get { return HasComponent(GameComponentsLookup.Capacity); } }

    public void AddCapacity(float newValue) {
        var index = GameComponentsLookup.Capacity;
        var component = (Capacity)CreateComponent(index, typeof(Capacity));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceCapacity(float newValue) {
        var index = GameComponentsLookup.Capacity;
        var component = (Capacity)CreateComponent(index, typeof(Capacity));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveCapacity() {
        RemoveComponent(GameComponentsLookup.Capacity);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCapacity;

    public static Entitas.IMatcher<GameEntity> Capacity {
        get {
            if (_matcherCapacity == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Capacity);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCapacity = matcher;
            }

            return _matcherCapacity;
        }
    }
}