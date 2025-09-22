---
title: "Class MyDLCs"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyDLCs.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyDLCs"
---

# Class MyDLCs | Space Engineers ModAPI

Class for storing DLC ids.

##### Inheritance

System.Object

MyDLCs

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyDLCs : Object
```

### Constructors

#### MyDLCs()

##### Declaration

### Fields

#### DLC\_NAME\_Frostbite

##### Declaration

```
public static readonly string DLC_NAME_Frostbite
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Properties

#### DLCs

##### Declaration

```
public static DictionaryReader<uint, MyDlcDefinition> DLCs { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.UInt32, [MyDlcDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDlcDefinition.html)\> |     |

### Methods

#### GetDLC(String)

##### Declaration

```
public static MyDlcDefinition GetDLC(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDlcDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDlcDefinition.html) |     |

#### GetDLCIcon(UInt32)

##### Declaration

```
public static string GetDLCIcon(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetRequiredDLCStoreHint(UInt32)

##### Declaration

```
public static string GetRequiredDLCStoreHint(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetRequiredDLCTooltip(String)

##### Declaration

```
public static string GetRequiredDLCTooltip(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetRequiredDLCTooltip(UInt32)

##### Declaration

```
public static string GetRequiredDLCTooltip(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### InitByDefinitions(ListReader<MyDlcDefinition>)

##### Declaration

```
public static void InitByDefinitions(ListReader<MyDlcDefinition> dlcDefinitions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyDlcDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDlcDefinition.html)\> | dlcDefinitions |     |

#### IsDLCSupported(String)

##### Declaration

```
public static bool IsDLCSupported(string dlcIdentifier)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | dlcIdentifier |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SetUnsupported(String)

##### Declaration

```
public static void SetUnsupported(string dlcIdentifier)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | dlcIdentifier |     |

#### TryGetDLC(String, out MyDlcDefinition)

##### Declaration

```
public static bool TryGetDLC(string name, out MyDlcDefinition dlc)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| [MyDlcDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDlcDefinition.html) | dlc |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryGetDLC(UInt32, out MyDlcDefinition)

##### Declaration

```
public static bool TryGetDLC(uint id, out MyDlcDefinition dlc)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |
| [MyDlcDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDlcDefinition.html) | dlc |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |