---
title: "Class MyComponentStack"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyComponentStack.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MyComponentStack"
---

# Class MyComponentStack | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentStack

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyComponentStack : Object, IMyComponentStack
```

### Constructors

#### MyComponentStack(MyCubeBlockDefinition, Single, Single)

##### Declaration

```
public MyComponentStack(MyCubeBlockDefinition BlockDefinition, float integrityPercent, float buildPercent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) | BlockDefinition |     |
| System.Single | integrityPercent |     |
| System.Single | buildPercent |     |

### Fields

#### BuildIntegrityChanged

##### Declaration

```
public Action<MyComponentStack, float, float> BuildIntegrityChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyComponentStack](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyComponentStack.html), System.Single, System.Single\> |     |

#### IntegrityChanged

##### Declaration

```
public Action<MyComponentStack, float, float> IntegrityChanged
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<[MyComponentStack](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyComponentStack.html), System.Single, System.Single\> |     |

#### MOUNT\_THRESHOLD

Mount threshold, required because of float inaccuracy. Component that has integrity beyond this threshold is considered unmounted. The integrity of the whole stack will never fall beyond this level (unless the stack is fully dismounted)

##### Declaration

```
public const float MOUNT_THRESHOLD = 1.52590219E-05F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### BuildIntegrity

##### Declaration

```
public float BuildIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BuildRatio

##### Declaration

```
public float BuildRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GroupCount

##### Declaration

```
public int GroupCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Integrity

##### Declaration

```
public float Integrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IntegrityRatio

##### Declaration

```
public float IntegrityRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsBuilt

Whether the block is built based on build-time integrity (construction state) and the final model can be shown. Uses [BuildIntegrity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyComponentStack.html#Sandbox_Game_Entities_MyComponentStack_BuildIntegrity) for the check.

##### Declaration

```
public bool IsBuilt { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsDestroyed

##### Declaration

```
public bool IsDestroyed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFullIntegrity

##### Declaration

```
public bool IsFullIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFullyDismounted

##### Declaration

```
public bool IsFullyDismounted { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsFunctional

Component stack is functional when critical part is not destroyed (integrity > 0). IMPORTANT: When you change the logic beyond this property, don't forget to call CheckFunctionalState every time the functional state could have been changed! (Also, remove calls to CheckFunctionalState where no longer needed)

##### Declaration

```
public bool IsFunctional { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastChangeStamp

##### Declaration

```
public int LastChangeStamp { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxIntegrity

##### Declaration

```
public float MaxIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### NewBlockIntegrity

##### Declaration

```
public static float NewBlockIntegrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### YieldLastComponent

##### Declaration

```
public bool YieldLastComponent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ApplyDamage(Single, MyConstructionStockpile)

Applies damage to the component stack. The method works almost the same as dismounting, it just leaves the build level at the original value and also the parts that are put into the outputStockpile are damaged.

##### Declaration

```
public void ApplyDamage(float damage, MyConstructionStockpile outputStockpile = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConstructionStockpile.html) | outputStockpile |     |

#### CanContinueBuild(MyInventoryBase, MyConstructionStockpile)
