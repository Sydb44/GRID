---
title: "Class MyDefinitionErrors.Error"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionErrors.Error.html"
category: "Misc"
namespace: "VRage.Game.MyDefinitionErrors"
class: "Error"
---

# Class MyDefinitionErrors.Error | Space Engineers ModAPI

##### Inheritance

System.Object

MyDefinitionErrors.Error

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class Error : Object
```

### Constructors

#### Error()

##### Declaration

### Fields

#### ErrorFile

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Message

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ModName

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Severity

##### Declaration

```
public TErrorSeverity Severity
```

##### Field Value

| Type | Description |
| --- | --- |
| [TErrorSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.TErrorSeverity.html) |     |

### Properties

#### ErrorId

##### Declaration

```
public string ErrorId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ErrorSeverity

##### Declaration

```
public string ErrorSeverity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### GetSeverityColor()

##### Declaration

```
public Color GetSeverityColor()
```

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### GetSeverityColor(TErrorSeverity)

##### Declaration

```
public static Color GetSeverityColor(TErrorSeverity severity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TErrorSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.TErrorSeverity.html) | severity |     |

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### GetSeverityName(TErrorSeverity, Boolean)

##### Declaration

```
public static string GetSeverityName(TErrorSeverity severity, bool plural)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [TErrorSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.TErrorSeverity.html) | severity |     |
| System.Boolean | plural |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |