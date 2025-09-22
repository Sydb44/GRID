---
title: "Class MySoundPair"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MySoundPair"
---

# Class MySoundPair | Space Engineers ModAPI

##### Inheritance

System.Object

MySoundPair

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MySoundPair : Object
```

### Constructors

#### MySoundPair()

##### Declaration

#### MySoundPair(String, Boolean)

##### Declaration

```
public MySoundPair(string cueName, bool useLog = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | cueName |     |
| System.Boolean | useLog |     |

### Fields

#### Empty

##### Declaration

```
public static MySoundPair Empty
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

### Properties

#### Arcade

##### Declaration

```
public MyCueId Arcade { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Audio.MyCueId |     |

#### Realistic

##### Declaration

```
public MyCueId Realistic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Audio.MyCueId |     |

#### SoundId

##### Declaration

```
public MyCueId SoundId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Audio.MyCueId |     |

### Methods

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCueId(String)

##### Declaration

```
public static MyCueId GetCueId(string cueName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | cueName |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Audio.MyCueId |     |

#### GetCueName()

##### Declaration

```
public string GetCueName()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Init(String, Boolean)

##### Declaration

```
public void Init(string cueName, bool useLog = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | cueName |     |
| System.Boolean | useLog |     |

#### Init(MyCueId)

##### Declaration

```
public void Init(MyCueId cueId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Audio.MyCueId | cueId |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |