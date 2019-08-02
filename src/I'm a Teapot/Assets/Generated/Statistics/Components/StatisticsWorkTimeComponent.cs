//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StatisticsContext {

    public StatisticsEntity workTimeEntity { get { return GetGroup(StatisticsMatcher.WorkTime).GetSingleEntity(); } }
    public WorkTime workTime { get { return workTimeEntity.workTime; } }
    public bool hasWorkTime { get { return workTimeEntity != null; } }

    public StatisticsEntity SetWorkTime(float newValue) {
        if (hasWorkTime) {
            throw new Entitas.EntitasException("Could not set WorkTime!\n" + this + " already has an entity with WorkTime!",
                "You should check if the context already has a workTimeEntity before setting it or use context.ReplaceWorkTime().");
        }
        var entity = CreateEntity();
        entity.AddWorkTime(newValue);
        return entity;
    }

    public void ReplaceWorkTime(float newValue) {
        var entity = workTimeEntity;
        if (entity == null) {
            entity = SetWorkTime(newValue);
        } else {
            entity.ReplaceWorkTime(newValue);
        }
    }

    public void RemoveWorkTime() {
        workTimeEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class StatisticsEntity {

    public WorkTime workTime { get { return (WorkTime)GetComponent(StatisticsComponentsLookup.WorkTime); } }
    public bool hasWorkTime { get { return HasComponent(StatisticsComponentsLookup.WorkTime); } }

    public void AddWorkTime(float newValue) {
        var index = StatisticsComponentsLookup.WorkTime;
        var component = (WorkTime)CreateComponent(index, typeof(WorkTime));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceWorkTime(float newValue) {
        var index = StatisticsComponentsLookup.WorkTime;
        var component = (WorkTime)CreateComponent(index, typeof(WorkTime));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveWorkTime() {
        RemoveComponent(StatisticsComponentsLookup.WorkTime);
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
public sealed partial class StatisticsMatcher {

    static Entitas.IMatcher<StatisticsEntity> _matcherWorkTime;

    public static Entitas.IMatcher<StatisticsEntity> WorkTime {
        get {
            if (_matcherWorkTime == null) {
                var matcher = (Entitas.Matcher<StatisticsEntity>)Entitas.Matcher<StatisticsEntity>.AllOf(StatisticsComponentsLookup.WorkTime);
                matcher.componentNames = StatisticsComponentsLookup.componentNames;
                _matcherWorkTime = matcher;
            }

            return _matcherWorkTime;
        }
    }
}
