using Entitas;
using Entitas.CodeGeneration.Attributes;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

public class Timeout : IComponent { public float value; public override string ToString() => $"{value:F1}"; }

public class Employee : IComponent { }
public class Thirsty : IComponent { }
public class AtKitchen : IComponent { }

[Statistics] [Unique] public class CumulativeWaitTime : IComponent { public float value; }
