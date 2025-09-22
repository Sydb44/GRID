---
title: "Class MyMeteor.MyMeteorGameLogic"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyMeteor.MyMeteorGameLogic.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyMeteor"
class: "MyMeteorGameLogic"
---

# Class MyMeteor.MyMeteorGameLogic | Space Engineers ModAPI

##### Inheritance

System.Object

MyMeteor.MyMeteorGameLogic

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyMeteorGameLogic : MyEntityGameLogic, IMyEntityComponentBase, IMyComponentBase, IMyGameLogicComponent
```

### Constructors

#### MyMeteorGameLogic()

##### Declaration

```
public MyMeteorGameLogic()
```

### Fields

#### Item

##### Declaration

```
public MyPhysicalInventoryItem Item
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) |     |

### Properties

#### Integrity

##### Declaration

```
public float Integrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### VoxelMaterial

##### Declaration

```
public MyVoxelMaterialDefinition VoxelMaterial { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html) |     |

### Methods

#### Close()

##### Declaration

```
public override void Close()
```

##### Overrides

#### DoDamage(Single, MyStringHash, Boolean, Nullable<MyHitInfo>, Int64, Nullable<MyStringHash>)

##### Declaration

```
public void DoDamage(float damage, MyStringHash damageType, bool sync, Nullable<MyHitInfo> hitInfo, long attackerId, Nullable<MyStringHash> extraInfo = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |
| System.Boolean | sync |     |
| System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\> | hitInfo |     |
| System.Int64 | attackerId |     |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo |     |

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### GetPhysicsShape(HkMassProperties, Single, Single)

##### Declaration

```
protected virtual HkShape GetPhysicsShape(HkMassProperties massProperties, float mass, float scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Havok.HkMassProperties | massProperties |     |
| System.Single | mass |     |
| System.Single | scale |     |

##### Returns

| Type | Description |
| --- | --- |
| Havok.HkShape |     |

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

#### MarkForClose()

##### Declaration

```
public override void MarkForClose()
```

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnAddedToScene()

##### Declaration

```
public override void OnAddedToScene()
```

##### Overrides

#### OnDestroy()

##### Declaration

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Extension Methods