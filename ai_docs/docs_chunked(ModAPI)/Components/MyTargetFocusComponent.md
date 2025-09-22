---
title: "Class MyTargetFocusComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetFocusComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyTargetFocusComponent"
---

# Class MyTargetFocusComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyTargetFocusComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyTargetFocusComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent
```

### Constructors

#### MyTargetFocusComponent()

##### Declaration

```
public MyTargetFocusComponent()
```

### Properties

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### CurrentTarget

##### Declaration

```
public MyEntity CurrentTarget { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### FocusSearchMaxDistance

##### Declaration

```
public double FocusSearchMaxDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### FocusSearchMaxDistanceSquared

##### Declaration

```
public double FocusSearchMaxDistanceSquared { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### GridId

##### Declaration

```
public Nullable<long> GridId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### IsLocallyControlled

##### Declaration

```
public bool IsLocallyControlled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsTargetLockingEnabledInController

##### Declaration

```
public bool IsTargetLockingEnabledInController { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### IsTargetInRange(MatrixD, MyEntity, out Double, Boolean)

##### Declaration

```
public bool IsTargetInRange(MatrixD shooterMatrix, MyEntity target, out double targetCosSquaredSigned, bool checkAngle = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | shooterMatrix |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | target |     |
| System.Double | targetCosSquaredSigned |     |
| System.Boolean | checkAngle |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LookupSuperGridsInRange()

##### Declaration

```
public void LookupSuperGridsInRange()
```

#### OnLockRequest()

##### Declaration

```
public void OnLockRequest()
```

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

#### UpdateAimVector()

##### Declaration

```
public void UpdateAimVector()
```

### Extension Methods