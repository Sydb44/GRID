---
title: "Class MyHandToolBase.MyBlockingBody"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyHandToolBase.MyBlockingBody.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyHandToolBase"
class: "MyBlockingBody"
---

# Class MyHandToolBase.MyBlockingBody | Space Engineers ModAPI

##### Inheritance

System.Object

Sandbox.Engine.Physics.MyPhysicsBody

MyHandToolBase.MyBlockingBody

##### Inherited Members

[MyPhysicsComponentBase.CreateCharacterCollision(Vector3, Single, Single, Single, Single, Single, Single, MatrixD, Single, UInt16, Boolean, Single, Single, Single, Boolean, Nullable<Single>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html#VRage_Game_Components_MyPhysicsComponentBase_CreateCharacterCollision_VRageMath_Vector3_System_Single_System_Single_System_Single_System_Single_System_Single_System_Single_VRageMath_MatrixD_System_Single_System_UInt16_System_Boolean_System_Single_System_Single_System_Single_System_Boolean_System_Nullable_System_Single__)

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyBlockingBody : MyPhysicsBody, IMyEntityComponentBase, IMyComponentBase, MyClusterTree.IMyActivationHandler
```

### Constructors

#### MyBlockingBody(MyHandToolBase, MyEntity)

##### Declaration

```
public MyBlockingBody(MyHandToolBase tool, MyEntity owner)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyHandToolBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyHandToolBase.html) | tool |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | owner |     |

### Properties

#### HandTool

##### Declaration

```
public MyHandToolBase HandTool { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyHandToolBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyHandToolBase.html) |     |

### Methods

#### OnWorldPositionChanged(Object)

##### Declaration

```
public override void OnWorldPositionChanged(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

Sandbox.Engine.Physics.MyPhysicsBody.OnWorldPositionChanged(System.Object)

#### SetWorldMatrix(MatrixD)

##### Declaration

```
public void SetWorldMatrix(MatrixD worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |

### Extension Methods