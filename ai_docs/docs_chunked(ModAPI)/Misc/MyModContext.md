---
title: "Class MyModContext"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyModContext"
---

# Class MyModContext | Space Engineers ModAPI

##### Inheritance

System.Object

MyModContext

##### Implements

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyModContext : Object, IEquatable<MyModContext>, IMyModContext
```

### Constructors

#### MyModContext()

##### Declaration

### Fields

#### CurrentFile

##### Declaration

```
public string CurrentFile
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Properties

#### BaseGame

##### Declaration

```
public static MyModContext BaseGame { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) |     |

#### IsBaseGame

##### Declaration

```
public bool IsBaseGame { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ModId

##### Declaration

```
public string ModId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ModItem

##### Declaration

```
public MyObjectBuilder_Checkpoint.ModItem ModItem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Checkpoint.ModItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.ModItem.html) |     |

#### ModName

##### Declaration

```
public string ModName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ModPath

##### Declaration

```
public string ModPath { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ModPathData

##### Declaration

```
public string ModPathData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ModServiceName

##### Declaration

```
public string ModServiceName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### UnknownContext

##### Declaration

```
public static MyModContext UnknownContext { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) |     |

### Methods

#### Equals(MyModContext)

##### Declaration

```
public bool Equals(MyModContext other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Init(String, String, String)

##### Declaration

```
public void Init(string modName, string fileName, string modPath = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | modName |     |
| System.String | fileName |     |
| System.String | modPath |     |

#### Init(MyModContext)

##### Declaration

```
public void Init(MyModContext context)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) | context |     |

#### Init(MyObjectBuilder\_Checkpoint.ModItem)

##### Declaration

```
public void Init(MyObjectBuilder_Checkpoint.ModItem modItem)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Checkpoint.ModItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.ModItem.html) | modItem |     |

### Implements