---
title: "Class TerminalPropertyExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.TerminalPropertyExtensions.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces"
class: "TerminalPropertyExtensions"
---

# Class TerminalPropertyExtensions | Space Engineers ModAPI

Terminal block extension for property access

##### Inheritance

System.Object

TerminalPropertyExtensions

###### **Namespace**: [Sandbox.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public static class TerminalPropertyExtensions : Object
```

### Methods

#### As<TValue>(ITerminalProperty)

Property type cast

##### Declaration

```
public static ITerminalProperty<TValue> As<TValue>(this ITerminalProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) | property | [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) reference |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html)<TValue> | reference to [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) value of specified type |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### AsBool(ITerminalProperty)

Property type cast

##### Declaration

```
public static ITerminalProperty<bool> AsBool(this ITerminalProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) | property | [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) reference |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html)<System.Boolean\> | reference to [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) value of specified type (bool) |

#### AsColor(ITerminalProperty)

Property type cast

##### Declaration

```
public static ITerminalProperty<Color> AsColor(this ITerminalProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) | property | [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) reference |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html)<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> | reference to [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) value of specified type (Color) |

#### AsFloat(ITerminalProperty)

Property type cast

##### Declaration

```
public static ITerminalProperty<float> AsFloat(this ITerminalProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) | property | [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) reference |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html)<System.Single\> | reference to [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) value of specified type (float) |

#### Cast<TValue>(ITerminalProperty)

Property type cast

##### Declaration

```
public static ITerminalProperty<TValue> Cast<TValue>(this ITerminalProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) | property | [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) reference |

##### Returns

| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html)<TValue> | reference to [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) value of specified type |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetDefaultValue<T>(IMyTerminalBlock, String)

Returns default value of specified property as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName)
