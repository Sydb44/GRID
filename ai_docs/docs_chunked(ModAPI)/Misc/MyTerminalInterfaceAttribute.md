---
title: "Class MyTerminalInterfaceAttribute"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyTerminalInterfaceAttribute.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyTerminalInterfaceAttribute"
---

  Class MyTerminalInterfaceAttribute | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Class MyTerminalInterfaceAttribute

Used on block classes inheriting MyTerminalBlock. Attribute tells the terminal system which interface types should be linked to this class.

##### Inheritance

System.Object

MyTerminalInterfaceAttribute

###### **Namespace**: [Sandbox.ModAPI](Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyTerminalInterfaceAttribute : Attribute
```

### Constructors

#### MyTerminalInterfaceAttribute(Type\[\])

##### Declaration

```
public MyTerminalInterfaceAttribute(params Type[] linkedTypes)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type\[\] | linkedTypes |     |

### Fields

#### LinkedTypes

##### Declaration

```
public readonly Type[] LinkedTypes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Type\[\] |     |

_☀_

_☾_