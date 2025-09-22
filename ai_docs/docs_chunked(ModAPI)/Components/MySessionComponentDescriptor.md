---
title: "Class MySessionComponentDescriptor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySessionComponentDescriptor.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MySessionComponentDescriptor"
---

  Class MySessionComponentDescriptor | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MySessionComponentDescriptor

##### Inheritance

System.Object

MySessionComponentDescriptor

###### **Namespace**: [VRage.Game.Components](VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MySessionComponentDescriptor : Attribute
```

### Constructors

#### MySessionComponentDescriptor(MyUpdateOrder)

##### Declaration

```
public MySessionComponentDescriptor(MyUpdateOrder updateOrder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyUpdateOrder](VRage.Game.Components.MyUpdateOrder.html) | updateOrder |     |

#### MySessionComponentDescriptor(MyUpdateOrder, Int32)

##### Declaration

```
public MySessionComponentDescriptor(MyUpdateOrder updateOrder, int priority)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyUpdateOrder](VRage.Game.Components.MyUpdateOrder.html) | updateOrder |     |
| System.Int32 | priority |     |

#### MySessionComponentDescriptor(MyUpdateOrder, Int32, Type, Type, Boolean)

##### Declaration

```
public MySessionComponentDescriptor(MyUpdateOrder updateOrder, int priority, Type obType, Type registrationType = null, bool serverOnly = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyUpdateOrder](VRage.Game.Components.MyUpdateOrder.html) | updateOrder |     |
| System.Int32 | priority |     |
| System.Type | obType |     |
| System.Type | registrationType |     |
| System.Boolean | serverOnly |     |

### Fields

#### ComponentType

##### Declaration

```
public Type ComponentType
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Type |     |

#### ObjectBuilderType

##### Declaration

```
public MyObjectBuilderType ObjectBuilderType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### Priority

Lower Priority is loaded before higher Priority

##### Declaration

```
public int Priority
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### UpdateOrder

##### Declaration

```
public MyUpdateOrder UpdateOrder
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyUpdateOrder](VRage.Game.Components.MyUpdateOrder.html) |     |

### Properties

#### IsServerOnly

Is server only is used for client request of the world. if the component is server only, it's not sent to the client on world request.

##### Declaration

```
public bool IsServerOnly { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

_☀_

_☾_