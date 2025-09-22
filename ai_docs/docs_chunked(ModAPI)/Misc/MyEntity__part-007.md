System.Boolean

state

#### Simulate()

##### Declaration

```
public virtual void Simulate()
```

#### Teleport(MatrixD, Object, Boolean)

##### Declaration

```
public virtual void Teleport(MatrixD worldMatrix, object source = null, bool ignoreAssert = false)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

System.Object

source

System.Boolean

ignoreAssert

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### TryGetDebugRenderComponent<T>(out T)

##### Declaration

```
public bool TryGetDebugRenderComponent<T>(out T debugComponent)
```

##### Parameters

Type

Name

Description

T

debugComponent

##### Returns

Type

Description

System.Boolean

##### Type Parameters

Name

Description

T

#### TryGetSubpart(String, out MyEntitySubpart)

##### Declaration

```
public bool TryGetSubpart(string name, out MyEntitySubpart subpart)
```

##### Parameters

Type

Name

Description

System.String

name

[MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html)

subpart

##### Returns

Type

Description

System.Boolean

#### Unpin()

##### Declaration

#### UpdateAfterSimulation()

##### Declaration

```
public virtual void UpdateAfterSimulation()
```

#### UpdateAfterSimulation10()

##### Declaration

```
public virtual void UpdateAfterSimulation10()
```

#### UpdateAfterSimulation100()

##### Declaration

```
public virtual void UpdateAfterSimulation100()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public virtual void UpdateBeforeSimulation()
```

#### UpdateBeforeSimulation10()

Called each 10th frame if registered for update10

##### Declaration

```
public virtual void UpdateBeforeSimulation10()
```

#### UpdateBeforeSimulation100()

Called each 100th frame if registered for update100

##### Declaration

```
public virtual void UpdateBeforeSimulation100()
```

#### UpdateGamePruningStructure()

##### Declaration

```
public void UpdateGamePruningStructure()
```

#### UpdateNamedEmissiveParts(UInt32, String, Color, Single)

##### Declaration

```
protected static void UpdateNamedEmissiveParts(uint renderObjectId, string emissiveName, Color emissivePartColor, float emissivity)
```

##### Parameters

Type

Name

Description

System.UInt32

renderObjectId

System.String

emissiveName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

emissivePartColor

System.Single

emissivity

#### UpdateOnceBeforeFrame()

##### Declaration

```
public virtual void UpdateOnceBeforeFrame()
```

#### UpdateSoundContactPoint(Int64, Vector3, Vector3, Vector3, Single)

##### Declaration

```
public void UpdateSoundContactPoint(long entityId, Vector3 localPosition, Vector3 normal, Vector3 separatingVelocity, float separatingSpeed)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

localPosition

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

separatingVelocity

System.Single

separatingSpeed

#### UpdatingStopped()

##### Declaration

```
public virtual void UpdatingStopped()
```

### Events

#### AddedToScene

##### Declaration

```
public event Action<MyEntity> AddedToScene
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnClose

##### Declaration

```
public event Action<MyEntity> OnClose
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnClosing

##### Declaration

```
public event Action<MyEntity> OnClosing
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnDebugDraw

##### Declaration

```
public event Action<MyEntity> OnDebugDraw
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnMarkForClose

This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed

##### Declaration

```
public event Action<MyEntity> OnMarkForClose
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnModelRefresh

##### Declaration

```
public event Action<MyEntity> OnModelRefresh
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnPhysicsChanged

##### Declaration

```
public event Action<MyEntity> OnPhysicsChanged
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### OnPhysicsComponentChanged

##### Declaration

```
public event Action<MyPhysicsComponentBase, MyPhysicsComponentBase> OnPhysicsComponentChanged
```

##### Event Type

Type

Description

System.Action<[MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html), [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html)\>

#### OnTeleported

##### Declaration

```
public event Action<MyEntity> OnTeleported
```

##### Event Type

Type

Description

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>
