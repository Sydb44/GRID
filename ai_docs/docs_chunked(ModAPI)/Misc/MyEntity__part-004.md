Type

Description

[MyEntity.UpdateDurationType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.UpdateDurationType.html)

#### WorldMatrix

##### Declaration

```
public MatrixD WorldMatrix { get; set; }
```

##### Property Value

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

### Methods

#### AddDebugRenderComponent(MyDebugRenderComponentBase)

##### Declaration

```
public void AddDebugRenderComponent(MyDebugRenderComponentBase render)
```

##### Parameters

Type

Name

Description

[MyDebugRenderComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyDebugRenderComponentBase.html)

render

#### AddToGamePruningStructure()

##### Declaration

```
public void AddToGamePruningStructure()
```

#### AfterPaste()

##### Declaration

```
public virtual void AfterPaste()
```

#### ApplyLastControls()

##### Declaration

```
public virtual void ApplyLastControls()
```

#### BeforeDelete()

##### Declaration

```
protected virtual void BeforeDelete()
```

#### BeforeGameLogicInit()

Called right before initializing the GameLogic component, during entity Init.

##### Declaration

```
protected virtual void BeforeGameLogicInit()
```

#### BeforePaste()

##### Declaration

```
public virtual void BeforePaste()
```

#### BeforeSave()

Called before method GetObjectBuilder, when saving sector

##### Declaration

```
public virtual void BeforeSave()
```

#### CanBeAddedToRender()

##### Declaration

```
protected virtual bool CanBeAddedToRender()
```

##### Returns

Type

Description

System.Boolean

#### ClampToWorld()

##### Declaration

```
protected virtual void ClampToWorld()
```

#### ClearDebugRenderComponents()

##### Declaration

```
public void ClearDebugRenderComponents()
```

#### Close()

This method marks this entity for close which means, that Close will be called after all entities are updated

##### Declaration

#### Closing()

##### Declaration

```
protected virtual void Closing()
```

#### Components\_ComponentAdded(Type, IMyEntityComponentBase)

##### Declaration

```
protected virtual void Components_ComponentAdded(Type t, IMyEntityComponentBase c)
```

##### Parameters

Type

Name

Description

System.Type

t

VRage.Game.Components.Interfaces.IMyEntityComponentBase

c

#### Components\_ComponentRemoved(Type, IMyEntityComponentBase)

##### Declaration

```
protected virtual void Components_ComponentRemoved(Type t, IMyEntityComponentBase c)
```

##### Parameters

Type

Name

Description

System.Type

t

VRage.Game.Components.Interfaces.IMyEntityComponentBase

c

#### ContainsDebugRenderComponent(Type)

##### Declaration

```
public bool ContainsDebugRenderComponent(Type render)
```

##### Parameters

Type

Name

Description

System.Type

render

##### Returns

Type

Description

System.Boolean

#### CreateSync()

##### Declaration

#### DebugDraw()

##### Declaration

#### DebugDrawInvalidTriangles()

##### Declaration

```
public void DebugDrawInvalidTriangles()
```

#### DebugDrawPhysics()

Draw physical representation of entity

##### Declaration

```
public virtual void DebugDrawPhysics()
```

#### Delete()

Every object must have this method, but not every phys object must necessarily have something to cleanup

##### Declaration

#### DeserializeControls(BitStream, Boolean)

##### Declaration

```
public virtual void DeserializeControls(BitStream stream, bool outOfOrder)
```

##### Parameters

Type

Name

Description

VRage.Library.Collections.BitStream

stream

System.Boolean

outOfOrder

#### DoOverlapSphereTest(Single, Vector3D)

##### Declaration

```
public virtual bool DoOverlapSphereTest(float sphereRadius, Vector3D spherePos)
```

##### Parameters

Type

Name

Description

System.Single

sphereRadius

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

spherePos

##### Returns

Type

Description

System.Boolean

#### GetBaseEntity()

##### Declaration

```
public virtual MyEntity GetBaseEntity()
```

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetCubeBlockParent(MyEntity)

##### Declaration

```
public static IMyCubeBlock GetCubeBlockParent(MyEntity ent)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

ent

##### Returns

Type

Description

[IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeBlock.html)

#### GetDistanceBetweenCameraAndBoundingSphere()

##### Declaration

```
public double GetDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

Type

Description

System.Double

#### GetDistanceBetweenCameraAndPosition()

##### Declaration

```
public double GetDistanceBetweenCameraAndPosition()
```

##### Returns

Type

Description

System.Double

#### GetDistanceBetweenPlayerPositionAndBoundingSphere()

##### Declaration

```
public double GetDistanceBetweenPlayerPositionAndBoundingSphere()
```

##### Returns

Type

Description

System.Double

#### GetFriendlyName()

##### Declaration

```
public virtual string GetFriendlyName()
```

##### Returns

Type

Description

System.String

#### GetHudParams(Boolean)

##### Declaration

```
public virtual List<MyHudEntityParams> GetHudParams(bool allowBlink)
```

##### Parameters

Type

Name

Description

System.Boolean

allowBlink

##### Returns

Type

Description

System.Collections.Generic.List<VRage.Game.Gui.MyHudEntityParams\>

#### GetIntersectionWithAABB(ref BoundingBoxD)

##### Declaration

```
public virtual bool GetIntersectionWithAABB(ref BoundingBoxD aabb)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

aabb

##### Returns

Type

Description

System.Boolean
