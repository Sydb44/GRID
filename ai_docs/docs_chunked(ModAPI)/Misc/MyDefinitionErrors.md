---
title: "Class MyDefinitionErrors"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionErrors.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyDefinitionErrors"
---

# Class MyDefinitionErrors | Space Engineers ModAPI

##### Inheritance

System.Object

MyDefinitionErrors

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public static class MyDefinitionErrors : Object
```

### Properties

#### ShouldShowModErrors

##### Declaration

```
public static bool ShouldShowModErrors { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Add(MyModContext, String, TErrorSeverity, Boolean)

##### Declaration

```
public static void Add(MyModContext context, string message, TErrorSeverity severity, bool writeToLog = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) | context |     |
| System.String | message |     |
| [TErrorSeverity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.TErrorSeverity.html) | severity |     |
| System.Boolean | writeToLog |     |

#### Clear()

##### Declaration

```
public static void Clear()
```

#### GetErrors()

##### Declaration

```
public static ListReader<MyDefinitionErrors.Error> GetErrors()
```

##### Returns

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyDefinitionErrors.Error](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionErrors.Error.html)\> |     |

#### WriteError(MyDefinitionErrors.Error)

##### Declaration

```
public static void WriteError(MyDefinitionErrors.Error e)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionErrors.Error](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionErrors.Error.html) | e   |     |