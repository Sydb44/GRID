---
title: "Interface IMyComponentStack"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyComponentStack.html"
category: "Components"
namespace: "VRage.Game.ModAPI"
class: "IMyComponentStack"
---

# Interface IMyComponentStack | Space Engineers ModAPI

Describes component stack of the block

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyComponentStack
```

### Properties

#### BuildIntegrity

Gets the build integrity of the component stack

##### Declaration

```
float BuildIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BuildRatio

Gets the build ration of the component stack

##### Declaration

```
float BuildRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GroupCount

Gets count of the components in the group (stack). Use with GetComponentStackInfo to get components in the stack.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Integrity

Gets the integrity of the component stack

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IntegrityRatio

Gets the integrity ratio of the component stack

##### Declaration

```
float IntegrityRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsBuilt

Whether this component stack is built

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsDestroyed

Whether the component stack is destroyed

##### Declaration

```
bool IsDestroyed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFullIntegrity

Whether the component stack is at full integrity

##### Declaration

```
bool IsFullIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFullyDismounted

Whether the component stack is fully dismounted

##### Declaration

```
bool IsFullyDismounted { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFunctional

Whether this component stack is in functional state

##### Declaration

```
bool IsFunctional { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxIntegrity

Gets the max integrity of the component stack

##### Declaration

```
float MaxIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### YieldLastComponent

Whether the yield last component is enabled or not.

##### Declaration

```
bool YieldLastComponent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetAllMissingComponents(Dictionary<String, Int32>)

Gets missing components

##### Declaration

```
void GetAllMissingComponents(Dictionary<string, int> missingComponents)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Int32\> | missingComponents | dictionary of missing components (sub type name, count), can't be null |

#### GetComponentStackInfo(Int32)

##### Declaration

```
MyComponentStackInfo GetComponentStackInfo(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentStackInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyComponentStackInfo.html) |     |

#### GetMissingInfo(out Int32, out Int32)

Gets index and amount of missing component

##### Declaration

```
void GetMissingInfo(out int index, out int componentCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | index of the component |
| System.Int32 | componentCount |     |

### Events

#### IntegrityChanged

Triggers when integrity is changed

##### Declaration

```
event Action<IMyComponentStack, float, float> IntegrityChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyComponentStack](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyComponentStack.html), System.Single, System.Single\> |     |

#### IsFunctionalChanged

Triggers when functional state has changed

##### Declaration

```
event Action IsFunctionalChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |