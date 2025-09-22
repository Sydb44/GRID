---
title: "Interface IMyAttachableTopBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAttachableTopBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyAttachableTopBlock"
---

# Interface IMyAttachableTopBlock | Space Engineers ModAPI

Describes rotor,piston or wheel suspension attachable block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyAttachableTopBlock : IMyCubeBlock, IMyEntity
```

### Properties

#### Base

Gets the attached base block

##### Declaration

```
IMyMechanicalConnectionBlock Base { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyMechanicalConnectionBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMechanicalConnectionBlock.html) |     |

#### IsAttached

Gets whether the top part is attached to a base block

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |