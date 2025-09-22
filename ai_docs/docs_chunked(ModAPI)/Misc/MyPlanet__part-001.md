---
title: "Class MyPlanet"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanet.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyPlanet"
---

# Class MyPlanet | Space Engineers ModAPI

##### Inheritance

System.Object

MyPlanet

##### Implements

##### Inherited Members

[MyVoxelBase.IMyDecalProxy.AddDecals(MyHitInfo, MyStringHash, Vector3, Object, IMyDecalHandler, MyStringHash, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html#Sandbox_Game_Entities_MyVoxelBase_VRage_Game_ModAPI_Interfaces_IMyDecalProxy_AddDecals_VRage_Game_ModAPI_MyHitInfo__VRage_Utils_MyStringHash_VRageMath_Vector3_System_Object_VRage_Game_ModAPI_Interfaces_IMyDecalHandler_VRage_Utils_MyStringHash_VRage_Utils_MyStringHash_System_Boolean_VRageRender_MyDecalFlags_System_Int32_System_Collections_Generic_List_System_UInt32__)

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyPlanet : MyVoxelBase, IMyVoxelDrawable, IMyVoxelBase, IMyEntity, IMyEntity, IMyDecalProxy, IMyEventProxy, IMyEventOwner, IMyOxygenProvider
```

### Constructors

#### MyPlanet()

##### Declaration

### Fields

#### MemoryTracker

##### Declaration

```
public static MyMemorySystem MemoryTracker
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Library.Memory.MyMemorySystem |     |

#### PHYSICS\_SECTOR\_SIZE\_METERS

##### Declaration

```
public const int PHYSICS_SECTOR_SIZE_METERS = 1024
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RUN\_SECTORS

##### Declaration

```
public static bool RUN_SECTORS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### AtmosphereAltitude

##### Declaration

```
public float AtmosphereAltitude { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### AtmosphereRadius

##### Declaration

```
public float AtmosphereRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### AtmosphereSettings

##### Declaration

```
public MyAtmosphereSettings AtmosphereSettings { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRageRender.Messages.MyAtmosphereSettings |     |

#### AtmosphereWavelengths

##### Declaration

```
public Vector3 AtmosphereWavelengths { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### AverageRadius

##### Declaration

```
public float AverageRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Generator

##### Declaration

```
public MyPlanetGeneratorDefinition Generator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPlanetGeneratorDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPlanetGeneratorDefinition.html) |     |

#### GetInitArguments

##### Declaration

```
public MyPlanetInitArguments GetInitArguments { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPlanetInitArguments](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanetInitArguments.html) |     |

#### HasAtmosphere

##### Declaration

```
public bool HasAtmosphere { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaximumRadius

##### Declaration

```
public float MaximumRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinimumRadius

##### Declaration

```
public float MinimumRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PositionLeftBottomCorner

##### Declaration

```
public override Vector3D PositionLeftBottomCorner { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

##### Overrides

#### Provider

##### Declaration

```
public MyPlanetStorageProvider Provider { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Engine.Voxels.Planet.MyPlanetStorageProvider |     |

#### RootVoxel

##### Declaration

```
public override MyVoxelBase RootVoxel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

##### Overrides

#### ScaleGroup

##### Declaration

```
public override MyClipmapScaleEnum ScaleGroup { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyClipmapScaleEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyClipmapScaleEnum.html) |     |

##### Overrides

#### SpherizeWithDistance

##### Declaration

```
public bool SpherizeWithDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Storage

##### Declaration

```
public IMyStorage Storage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Voxels.IMyStorage |     |

### Methods

#### AddChildEntity(MyEntity)

##### Declaration

```
public void AddChildEntity(MyEntity child)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | child |     |

#### AddToStationOreBlockTree(ref MyDynamicAABBTree, Vector3D, Single)

##### Declaration

```
public void AddToStationOreBlockTree(ref MyDynamicAABBTree stationOreBlockTree, Vector3D position, float radius)
```
