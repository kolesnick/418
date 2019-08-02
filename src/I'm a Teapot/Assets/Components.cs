using System;
using Entitas;
using Entitas.CodeGeneration.Attributes;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

public class Timeout : IComponent { public float value; public override string ToString() => $"{TimeSpan.FromMinutes(value):h\\:mm}"; }

public class Employee : IComponent { }
public class Thirsty : IComponent { }
public class AtKitchen : IComponent { }

public class Teapot : IComponent { }

[Statistics] [Unique] public class CumulativeWaitTime : IComponent { public float value; public override string ToString() => $"Cumulative Wait Time: {TimeSpan.FromMinutes(value):d\\.hh\\:mm}"; }
