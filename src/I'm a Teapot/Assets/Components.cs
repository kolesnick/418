using Entitas;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

public class Timeout : IComponent { public float value; public override string ToString() => $"{value:F1}"; }

public class Employee : IComponent { }
public class Thirsty : IComponent { }
