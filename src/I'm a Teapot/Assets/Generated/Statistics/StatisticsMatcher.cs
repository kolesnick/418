//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ContextMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class StatisticsMatcher {

    public static Entitas.IAllOfMatcher<StatisticsEntity> AllOf(params int[] indices) {
        return Entitas.Matcher<StatisticsEntity>.AllOf(indices);
    }

    public static Entitas.IAllOfMatcher<StatisticsEntity> AllOf(params Entitas.IMatcher<StatisticsEntity>[] matchers) {
          return Entitas.Matcher<StatisticsEntity>.AllOf(matchers);
    }

    public static Entitas.IAnyOfMatcher<StatisticsEntity> AnyOf(params int[] indices) {
          return Entitas.Matcher<StatisticsEntity>.AnyOf(indices);
    }

    public static Entitas.IAnyOfMatcher<StatisticsEntity> AnyOf(params Entitas.IMatcher<StatisticsEntity>[] matchers) {
          return Entitas.Matcher<StatisticsEntity>.AnyOf(matchers);
    }
}