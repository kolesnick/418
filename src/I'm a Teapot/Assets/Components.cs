using System;
using Entitas;
using Entitas.CodeGeneration.Attributes;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming

public class Timeout : IComponent { public float value; public override string ToString() => $"{TimeSpan.FromMinutes(value):h\\:mm}"; }

public class Employee : IComponent { }
public class Working : IComponent { }
public class Thirsty : IComponent { }
public class AtKitchen : IComponent { }
public class FillingTeapot : IComponent { }

public class Teapot : IComponent { }
public class Temperature : IComponent { public float value; public override string ToString() => $"{value:F0}°"; }
public class Capacity : IComponent { public float value; }
public class Amount : IComponent { public float value; }
public class Empty : IComponent { }
public class Full : IComponent { }
public class BeingFilled : IComponent { }

[Settings] [Unique] public class TimeScale : IComponent { public float value; public override string ToString() => $"Time Scale: x{value:F1}"; }

[Statistics] [Unique] public class WorkTime : IComponent { public float value; public override string ToString() => $"Work Time: {TimeSpan.FromMinutes(value):d\\.hh\\:mm}"; }
[Statistics] [Unique] public class CumulativeWaitTime : IComponent { public float value; public override string ToString() => $"Cumulative Wait Time: {TimeSpan.FromMinutes(value):d\\.hh\\:mm}"; }
