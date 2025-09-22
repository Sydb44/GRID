---
title: "Class MyExplosions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosions.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyExplosions"
---

# Class MyExplosions | Space Engineers ModAPI

##### Inheritance

System.Object

MyExplosions

##### Inherited Members

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
[MySessionComponentDescriptor]
public class MyExplosions : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MyExplosions()

##### Declaration

### Properties

#### Dependencies

##### Declaration

```
public override Type[] Dependencies { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Type\[\] |     |

##### Overrides

### Methods

#### add\_OnExplosion(OnExplosionDel)

##### Declaration

```
public static void add_OnExplosion(OnExplosionDel value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [OnExplosionDel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.OnExplosionDel.html) | value |     |

#### AddExplosion(ref MyExplosionInfo, Boolean)

Add new explosion to the list, but caller needs to start it using Start() method

##### Declaration

```
public static bool AddExplosion(ref MyExplosionInfo explosionInfo, bool updateSync = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyExplosionInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosionInfo.html) | explosionInfo |     |
| System.Boolean | updateSync |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if explosion was successfully added, false otherwise |

#### Draw()

##### Declaration

```
public override void Draw()
```

##### Overrides

#### LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### remove\_OnExplosion(OnExplosionDel)

##### Declaration

```
public static void remove_OnExplosion(OnExplosionDel value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [OnExplosionDel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.OnExplosionDel.html) | value |     |

#### ShouldUseMassScaleForEntity(MyEntity)

##### Declaration

```
public static bool ShouldUseMassScaleForEntity(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UnloadData()

##### Declaration

```
protected override void UnloadData()
```

##### Overrides

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

### Events

#### OnExplosion

##### Declaration

```
public static event OnExplosionDel OnExplosion
```

##### Event Type

| Type | Description |
| --- | --- |
| [OnExplosionDel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.OnExplosionDel.html) |     |