//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Thirsty thirstyComponent = new Thirsty();

    public bool isThirsty {
        get { return HasComponent(GameComponentsLookup.Thirsty); }
        set {
            if (value != isThirsty) {
                var index = GameComponentsLookup.Thirsty;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : thirstyComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherThirsty;

    public static Entitas.IMatcher<GameEntity> Thirsty {
        get {
            if (_matcherThirsty == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Thirsty);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherThirsty = matcher;
            }

            return _matcherThirsty;
        }
    }
}
