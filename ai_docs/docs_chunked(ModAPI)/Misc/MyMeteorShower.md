---
title: "Class MyMeteorShower"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyMeteorShower.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyMeteorShower"
---

# Class MyMeteorShower | Space Engineers ModAPI

##### Inheritance

System.Object

MyMeteorShower

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MySessionComponentDescriptor]
[StaticEventOwner]
public class MyMeteorShower : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MyMeteorShower()

##### Declaration

### Properties

#### IsRequiredByGame

##### Declaration

```
public override bool IsRequiredByGame { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

### Methods

#### BeforeStart()

##### Declaration

```
public override void BeforeStart()
```

##### Overrides

#### CalculateShowerTime(MyEnvironmentHostilityEnum)

##### Declaration

```
public static TimeSpan CalculateShowerTime(MyEnvironmentHostilityEnum hostility)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentHostilityEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEnvironmentHostilityEnum.html) | hostility |     |

##### Returns

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### CalculateShowerTime(MyEnvironmentHostilityEnum, MyEnvironmentHostilityEnum, TimeSpan)

##### Declaration

```
public static TimeSpan CalculateShowerTime(MyEnvironmentHostilityEnum newHostility, MyEnvironmentHostilityEnum oldHostility, TimeSpan oldTime)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentHostilityEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEnvironmentHostilityEnum.html) | newHostility |     |
| [MyEnvironmentHostilityEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEnvironmentHostilityEnum.html) | oldHostility |     |
| System.TimeSpan | oldTime |     |

##### Returns

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### Draw()

##### Declaration

```
public override void Draw()
```

##### Overrides

#### GetActivationTime(MyEnvironmentHostilityEnum, Double, Double)

##### Declaration

```
public static double GetActivationTime(MyEnvironmentHostilityEnum hostility, double defaultMinMinutes, double defaultMaxMinutes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentHostilityEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEnvironmentHostilityEnum.html) | hostility |     |
| System.Double | defaultMinMinutes |     |
| System.Double | defaultMaxMinutes |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### GetInitialTime(MyEnvironmentHostilityEnum)

##### Declaration

```
public static Nullable<TimeSpan> GetInitialTime(MyEnvironmentHostilityEnum hostility)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentHostilityEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyEnvironmentHostilityEnum.html) | hostility |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.TimeSpan\> |     |

#### LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### MeteorWave(Object)

##### Declaration

```
[MyGlobalEventHandler]
public static void MeteorWave(object senderEvent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | senderEvent |     |

#### StartDebugWave(Vector3D, Nullable<Int32>, Single)

##### Declaration

```
public static void StartDebugWave(Vector3D pos, Nullable<int> amount = null, float radius = 100F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos |     |
| System.Nullable<System.Int32\> | amount |     |
| System.Single | radius |     |

#### UnloadData()

##### Declaration

```
protected override void UnloadData()
```

##### Overrides