---
title: "Interface IMySolarOccludable"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySolarOccludable.html"
category: "Power"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMySolarOccludable"
---

# Interface IMySolarOccludable | Space Engineers ModAPI

Describes an entity that registers when it is in a planetary shadow (PB scripting interface).

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySolarOccludable
```

### Properties

#### IsSolarOccluded

Whether the entity is in a planetary shadow.

##### Declaration

```
bool IsSolarOccluded { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetEntityId()

Obtains the entity ID either directly from itself or from its containing entity if the interface is used on a component.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 | ID of the given entity. |