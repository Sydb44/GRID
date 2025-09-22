---
title: "Interface IMyResourceStorageComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyResourceStorageComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyResourceStorageComponent"
---

# Interface IMyResourceStorageComponent | Space Engineers ModAPI

Describes a resource storage entity component for scripting

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyResourceStorageComponent
```

### Properties

#### FilledRatio

Gets the current fill level of this storage as a value between 0 (empty) and 1 (full).

##### Declaration

```
double FilledRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### ResourceCapacity

Gets the resource capacity of this tank.

##### Declaration

```
float ResourceCapacity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### IsResourceStorage(MyDefinitionId)

Can the storage store a specified resource?

##### Declaration

```
bool IsResourceStorage(MyDefinitionId resourceDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | resourceDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |