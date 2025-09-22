Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Init(StringBuilder, String, MyEntity, Nullable<Single>, String)

##### Declaration

```
public virtual void Init(StringBuilder displayName, string model, MyEntity parentObject, Nullable<float> scale, string modelCollision = null)
```

##### Parameters

Type

Name

Description

System.Text.StringBuilder

displayName

System.String

model

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

parentObject

System.Nullable<System.Single\>

scale

System.String

modelCollision

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public virtual void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

#### InitComponents()

##### Declaration

```
public virtual void InitComponents()
```

#### InitComponentsForTesting()

##### Declaration

```
public virtual void InitComponentsForTesting()
```

#### InstantiateSubpart(MyModelDummy, ref MyEntitySubpart.Data)

##### Declaration

```
protected virtual MyEntitySubpart InstantiateSubpart(MyModelDummy subpartDummy, ref MyEntitySubpart.Data data)
```

##### Parameters

Type

Name

Description

VRageRender.Import.MyModelDummy

subpartDummy

[MyEntitySubpart.Data](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.Data.html)

data

##### Returns

Type

Description

[MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html)

#### OnAddedToScene(Object)

Called when \[activated\] which for entity means that was added to scene.

##### Declaration

```
public virtual void OnAddedToScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

The source of activation.

#### OnCreateSync()

##### Declaration

```
protected virtual MySyncComponentBase OnCreateSync()
```

##### Returns

Type

Description

[MySyncComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySyncComponentBase.html)

#### OnInventoryComponentAdded(MyInventoryBase)

##### Declaration

```
protected virtual void OnInventoryComponentAdded(MyInventoryBase inventory)
```

##### Parameters

Type

Name

Description

[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)

inventory

#### OnInventoryComponentRemoved(MyInventoryBase)

##### Declaration

```
protected virtual void OnInventoryComponentRemoved(MyInventoryBase inventory)
```

##### Parameters

Type

Name

Description

[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)

inventory

#### OnRemovedFromScene(Object)

##### Declaration

```
public virtual void OnRemovedFromScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

#### OnReplicationEnded()

##### Declaration

```
public virtual void OnReplicationEnded()
```

#### OnReplicationStarted()

##### Declaration

```
public virtual void OnReplicationStarted()
```

#### Pin()

##### Declaration

```
public MyEntity.EntityPin Pin()
```

##### Returns

Type

Description

[MyEntity.EntityPin](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.EntityPin.html)

#### PrepareForDraw()

Method is called defacto from Update, preparation fo Draw

##### Declaration

```
public virtual void PrepareForDraw()
```

#### RaisePhysicsChanged()

##### Declaration

```
public void RaisePhysicsChanged()
```

#### RefreshModels(String, String)

##### Declaration

```
public virtual void RefreshModels(string model, string modelCollision)
```

##### Parameters

Type

Name

Description

System.String

model

System.String

modelCollision

#### RemoveDebugRenderComponent(Type)

##### Declaration

```
public void RemoveDebugRenderComponent(Type t)
```

##### Parameters

Type

Name

Description

System.Type

t

#### RemoveDebugRenderComponent(MyDebugRenderComponentBase)

##### Declaration

```
public void RemoveDebugRenderComponent(MyDebugRenderComponentBase render)
```

##### Parameters

Type

Name

Description

[MyDebugRenderComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyDebugRenderComponentBase.html)

render

#### RemoveFromGamePruningStructure()

##### Declaration

```
public void RemoveFromGamePruningStructure()
```

#### ResetControls()

##### Declaration

```
public virtual void ResetControls()
```

#### SerializeControls(BitStream)

##### Declaration

```
public virtual void SerializeControls(BitStream stream)
```

##### Parameters

Type

Name

Description

VRage.Library.Collections.BitStream

stream

#### SetEmissiveParts(String, Color, Single)

##### Declaration

```
public void SetEmissiveParts(string emissiveName, Color emissivePartColor, float emissivity)
```

##### Parameters

Type

Name

Description

System.String

emissiveName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

emissivePartColor

System.Single

emissivity

#### SetEmissivePartsForSubparts(String, Color, Single)

##### Declaration

```
public void SetEmissivePartsForSubparts(string emissiveName, Color emissivePartColor, float emissivity)
```

##### Parameters

Type

Name

Description

System.String

emissiveName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

emissivePartColor

System.Single

emissivity

#### SetFadeOut(Boolean)

##### Declaration

```
public void SetFadeOut(bool state)
```

##### Parameters

Type

Name

Description

System.Boolean

state

#### Simulate()

##### Declaration

```
public virtual void Simulate()
```

#### Teleport(MatrixD, Object, Boolean)
