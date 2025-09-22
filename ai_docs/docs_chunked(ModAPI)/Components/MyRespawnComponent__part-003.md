
[MyEntityRespawnComponentBase.IMyControllableEntity.PrimaryLookaround](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase.html#Sandbox_Game_EntityComponents_MyEntityRespawnComponentBase_VRage_Game_ModAPI_Interfaces_IMyControllableEntity_PrimaryLookaround)

[MyEntityRespawnComponentBase.IMyControllableEntity.RelativeDampeningDistance](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase.html#Sandbox_Game_EntityComponents_MyEntityRespawnComponentBase_VRage_Game_ModAPI_Interfaces_IMyControllableEntity_RelativeDampeningDistance)

[MyEntityRespawnComponentBase.IMyControllableEntity.RelativeDampeningTarget](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase.html#Sandbox_Game_EntityComponents_MyEntityRespawnComponentBase_VRage_Game_ModAPI_Interfaces_IMyControllableEntity_RelativeDampeningTarget)

[MyEntityComponentBase.Container](VRage.Game.Components.MyEntityComponentBase.html#VRage_Game_Components_MyEntityComponentBase_Container)

[MyEntityComponentBase.AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase.html#VRage_Game_Components_MyEntityComponentBase_AttachSyncToEntity)

[MyEntityComponentBase.OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase.html#VRage_Game_Components_MyEntityComponentBase_OnAfterAddedToContainer)

[MyEntityComponentBase.BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase.html#VRage_Game_Components_MyEntityComponentBase_BeforeRemovedFromContainer)

[MyComponentBase.SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_SetContainer_VRage_Game_Components_Interfaces_IMyComponentContainer_)

[MyComponentBase.GetAs<T>()](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_GetAs__1)

[MyComponentBase.Serialize(Boolean)](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_Serialize_System_Boolean_)

[MyComponentBase.Deserialize(MyObjectBuilder\_ComponentBase)](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_Deserialize_VRage_Game_ObjectBuilders_ComponentSystem_MyObjectBuilder_ComponentBase_)

[MyComponentBase.Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_Init_VRage_Game_MyComponentDefinitionBase_)

[MyComponentBase.IsSerialized()](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_IsSerialized)

[MyComponentBase.RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_RemoveExistingComponentOnNewInsert)

[MyComponentBase.ContainerBase](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_ContainerBase)

###### **Namespace**: [VRage.Game.Components](VRage.Game.Components.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyRespawnComponent : MyEntityRespawnComponentBase, IMyEntityComponentBase, IMyCameraController, IMyControllableEntity, IMyControllableEntity, IMyRespawnComponent, IMyComponentBase
```

### Constructors

#### MyRespawnComponent()

##### Declaration

```
public MyRespawnComponent()
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

[MyEntityComponentBase.ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase.html#VRage_Game_Components_MyEntityComponentBase_ComponentTypeDebugString)

#### Entity

##### Declaration

```
public MyTerminalBlock Entity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Cube.MyTerminalBlock |     |

#### SpawnWithoutOxygen

##### Declaration

```
public bool SpawnWithoutOxygen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CanPlayerSpawn(Int64, Boolean)

##### Declaration

```
public bool CanPlayerSpawn(long playerId, bool acceptPublicRespawn)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.Boolean | acceptPublicRespawn |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetAllRespawns()

##### Declaration

```
public static HashSetReader<MyRespawnComponent> GetAllRespawns()
```

##### Returns

| Type | Description |
| --- | --- |
| [HashSetReader](VRage.Collections.HashSetReader-1.html)<[MyRespawnComponent](VRage.Game.Components.MyRespawnComponent.html)\> |     |

#### GetOxygenLevel()

##### Declaration

```
public float GetOxygenLevel()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetSpawnPosition()

##### Declaration

```
public MatrixD GetSpawnPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](VRageMath.MatrixD.html) |     |

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

[MyEntityComponentBase.OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase.html#VRage_Game_Components_MyEntityComponentBase_OnAddedToContainer)

#### OnAddedToScene()

##### Declaration

```
public override void OnAddedToScene()
```

##### Overrides

[MyComponentBase.OnAddedToScene()](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_OnAddedToScene)

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

[MyEntityComponentBase.OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase.html#VRage_Game_Components_MyEntityComponentBase_OnBeforeRemovedFromContainer)

#### OnRemovedFromScene()

##### Declaration

```
public override void OnRemovedFromScene()
```

##### Overrides

[MyComponentBase.OnRemovedFromScene()](VRage.Game.Components.MyComponentBase.html#VRage_Game_Components_MyComponentBase_OnRemovedFromScene)
