##### Declaration

```
public static Action<MyEntity> MyWeldingGroupsAddNodeExtCallback
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### MyWeldingGroupsGetGroupNodesExtCallback

##### Declaration

```
public static Action<MyEntity, List<MyEntity>> MyWeldingGroupsGetGroupNodesExtCallback
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html), System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>>

#### MyWeldingGroupsGroupExistsExtCallback

##### Declaration

```
public static MyEntity.MyWeldingGroupsGroupExistsDelegate MyWeldingGroupsGroupExistsExtCallback
```

##### Field Value

Type

Description

[MyEntity.MyWeldingGroupsGroupExistsDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.MyWeldingGroupsGroupExistsDelegate.html)

#### MyWeldingGroupsRemoveNodeExtCallback

##### Declaration

```
public static Action<MyEntity> MyWeldingGroupsRemoveNodeExtCallback
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnEntityCloseRequest

##### Declaration

```
public Action<MyEntity> OnEntityCloseRequest
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### PropagateSubpartRotationThroughHieerarchy

##### Declaration

```
public bool PropagateSubpartRotationThroughHieerarchy
```

##### Field Value

Type

Description

System.Boolean

#### ReadyForReplicationAction

##### Declaration

```
public Dictionary<IMyReplicable, Action> ReadyForReplicationAction
```

##### Field Value

Type

Description

System.Collections.Generic.Dictionary<VRage.Network.IMyReplicable, System.Action\>

#### RemoveFromGamePruningStructureExtCallBack

##### Declaration

```
public static Action<MyEntity> RemoveFromGamePruningStructureExtCallBack
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### ReplicationEnded

##### Declaration

```
public Action ReplicationEnded
```

##### Field Value

Type

Description

System.Action

#### ReplicationStarted

##### Declaration

```
public Action ReplicationStarted
```

##### Field Value

Type

Description

System.Action

#### StaticForPruningStructure

##### Declaration

```
public bool StaticForPruningStructure
```

##### Field Value

Type

Description

System.Boolean

#### TargetPruningProxyId

##### Declaration

```
public int TargetPruningProxyId
```

##### Field Value

Type

Description

System.Int32

#### TopMostPruningProxyId

##### Declaration

```
public int TopMostPruningProxyId
```

##### Field Value

Type

Description

System.Int32

#### UpdateGamePruningStructureExtCallBack

##### Declaration

```
public static Action<MyEntity> UpdateGamePruningStructureExtCallBack
```

##### Field Value

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

### Properties

#### Closed

##### Declaration

```
public bool Closed { get; protected set; }
```

##### Property Value

Type

Description

System.Boolean

#### Components

##### Declaration

```
public IMyEntityComponentContainer Components { get; }
```

##### Property Value

Type

Description

VRage.Game.Components.Interfaces.IMyEntityComponentContainer

#### DebugName

##### Declaration

```
public string DebugName { get; }
```

##### Property Value

Type

Description

System.String

#### DisplayName

##### Declaration

```
public string DisplayName { get; set; }
```

##### Property Value

Type

Description

System.String

#### DisplayNameText

Display Name for GUI etc. Override in descendant classes. Usually used to display in terminal or inventory controls.

##### Declaration

```
public virtual string DisplayNameText { get; set; }
```

##### Property Value

Type

Description

System.String

#### EntityId

Entity id, can be set by subclasses (for example when using pool...)

##### Declaration

```
public long EntityId { get; set; }
```

##### Property Value

Type

Description

System.Int64

#### EntityStorage

##### Declaration

```
public MyEntityStorageComponent EntityStorage { get; set; }
```

##### Property Value

Type

Description

[MyEntityStorageComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityStorageComponent.html)

#### Flags

Gets or set some behavior of entity. [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html)

##### Declaration

```
public EntityFlags Flags { get; set; }
```

##### Property Value

Type

Description

[EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html)

#### GameLogic

##### Declaration

```
public virtual MyGameLogicComponent GameLogic { get; set; }
```

##### Property Value

Type

Description

[MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html)

#### HasInventory

Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventoryBase() != null.

##### Declaration

```
public bool HasInventory { get; }
```

##### Property Value

Type

Description

System.Boolean

#### Hierarchy

##### Declaration

```
public MyHierarchyComponent<MyEntity> Hierarchy { get; set; }
```

##### Property Value

Type

Description

[MyHierarchyComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponent-1.html)<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>
