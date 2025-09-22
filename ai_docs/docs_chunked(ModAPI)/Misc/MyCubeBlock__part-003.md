Name

Description

System.Type

t

VRage.Game.Components.Interfaces.IMyEntityComponentBase

c

##### Overrides

#### Components\_ComponentRemoved(Type, IMyEntityComponentBase)

##### Declaration

```
protected override void Components_ComponentRemoved(Type t, IMyEntityComponentBase c)
```

##### Parameters

Type

Name

Description

System.Type

t

VRage.Game.Components.Interfaces.IMyEntityComponentBase

c

##### Overrides

#### ConnectionAllowed(ref Vector3I, ref Vector3I, MyCubeBlockDefinition)

Returns true if this block can connect to another block (of the given type) in the given position. This is called only if CheckConnectionAllowed == true. If this method would return true for any position, set CheckConnectionAllowed to false to avoid unnecessary overhead. It is the block's responsibility to call CubeGrid.UpdateBlockNeighbors every time the conditions that are checked by this method change.

##### Declaration

```
public virtual bool ConnectionAllowed(ref Vector3I otherBlockPos, ref Vector3I faceNormal, MyCubeBlockDefinition def)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

otherBlockPos

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

faceNormal

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

##### Returns

Type

Description

System.Boolean

#### ConnectionAllowed(ref Vector3I, ref Vector3I, ref Vector3I, MyCubeBlockDefinition)

Whether connection is allowed to any of the positions between otherBlockMinPos and otherBlockMaxPos (both inclusive). Default implementation calls ConnectionAllowed(ref Vector3I otherBlockPos, ref Vector3I faceNormal) in a for loop. Override this in a subclass if this is not needed (for example, because all calls would return the same value for the same face)

##### Declaration

```
public virtual bool ConnectionAllowed(ref Vector3I otherBlockMinPos, ref Vector3I otherBlockMaxPos, ref Vector3I faceNormal, MyCubeBlockDefinition def)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

otherBlockMinPos

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

otherBlockMaxPos

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

faceNormal

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

##### Returns

Type

Description

System.Boolean

#### ContactPointCallback(ref MyGridContactInfo)

Return true when contact is valid

##### Declaration

```
public virtual void ContactPointCallback(ref MyGridContactInfo value)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MyGridContactInfo

value

#### CreateRenderer(MyPersistentEntityFlags2, Vector3, Object)

##### Declaration

```
public void CreateRenderer(MyPersistentEntityFlags2 persistentFlags, Vector3 colorMaskHsv, object modelStorage)
```

##### Parameters

Type

Name

Description

[MyPersistentEntityFlags2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyPersistentEntityFlags2.html)

persistentFlags

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

colorMaskHsv

System.Object

modelStorage

#### DisableUpdates()

##### Declaration

```
public virtual void DisableUpdates()
```

#### FriendlyWithBlock(MyCubeBlock)

Whether the two blocks are friendly. This relation is base on their owners and is symmetrical

##### Declaration

```
public bool FriendlyWithBlock(MyCubeBlock block)
```

##### Parameters

Type

Name

Description

[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)

block

##### Returns

Type

Description

System.Boolean

#### GetBlockGridOffset(MyCubeBlockDefinition)

Returns block offset in spawned grid.

##### Declaration

```
public static Vector3 GetBlockGridOffset(MyCubeBlockDefinition blockDefinition)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetComponent()

##### Declaration

```
public MyUpgradableBlockComponent GetComponent()
```

##### Returns

Type

Description

[MyUpgradableBlockComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyUpgradableBlockComponent.html)

#### GetDefaultEmissiveParts(Byte)

##### Declaration

```
protected virtual string GetDefaultEmissiveParts(byte index)
```

##### Parameters

Type

Name

Description

System.Byte

index

##### Returns

Type

Description

System.String

#### GetGeometryLocalBox()

##### Declaration

```
public virtual BoundingBox GetGeometryLocalBox()
```

##### Returns

Type

Description

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

#### GetInteractiveObject(UInt32)

##### Declaration

```
public IMyUseObject GetInteractiveObject(uint shapeKey)
```

##### Parameters

Type

Name

Description

System.UInt32

shapeKey

##### Returns

Type

Description

[IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html)

#### GetIntersectionWithLine(ref LineD, out Nullable<MyIntersectionResultLineTriangleEx>, IntersectionFlags)

##### Declaration

```
public override bool GetIntersectionWithLine(ref LineD line, out Nullable<MyIntersectionResultLineTriangleEx> t, IntersectionFlags flags)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Nullable<VRage.Game.Models.MyIntersectionResultLineTriangleEx\>

t

[IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html)

flags
