| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |
| System.Boolean | sync |     |
| System.Int64 | attackerId |     |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### GetPhysicsShape(Single, Single, out HkMassProperties)

##### Declaration

```
protected virtual HkShape GetPhysicsShape(float mass, float scale, out HkMassProperties massProperties)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | mass |     |
| System.Single | scale |     |
| Havok.HkMassProperties | massProperties |     |

##### Returns

| Type | Description |
| --- | --- |
| Havok.HkShape |     |

#### HasConstraints()

##### Declaration

```
public bool HasConstraints()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

#### OnDestroy()

##### Declaration

#### OnReplicationEnded()

##### Declaration

```
public override void OnReplicationEnded()
```

##### Overrides

#### OnReplicationStarted()

##### Declaration

```
public override void OnReplicationStarted()
```

##### Overrides

#### RefreshDisplayName()

##### Declaration

```
public void RefreshDisplayName()
```

#### RemoveUsers(Boolean)

##### Declaration

```
public void RemoveUsers(bool local)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | local |     |

#### SendCloseRequest()

##### Declaration

```
public void SendCloseRequest()
```

#### UpdateAfterSimulationParallel()

##### Declaration

```
public void UpdateAfterSimulationParallel()
```

#### UpdateBeforeSimulationParallel()

##### Declaration

```
public void UpdateBeforeSimulationParallel()
```

#### UpdateInternalState()

##### Declaration

```
public void UpdateInternalState()
```

### Explicit Interface Implementations

#### IMyUseObject.ActivationMatrix

##### Declaration

```
MatrixD IMyUseObject.ActivationMatrix { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### IMyUseObject.ContinuousUsage

##### Declaration

```
bool IMyUseObject.ContinuousUsage { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyUseObject.Dummy

##### Declaration

```
IMyModelDummy IMyUseObject.Dummy { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyModelDummy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModelDummy.html) |     |

#### IMyUseObject.GetActionInfo(UseActionEnum)

##### Declaration

```
MyActionDescription IMyUseObject.GetActionInfo(UseActionEnum actionEnum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) | actionEnum |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyActionDescription](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.MyActionDescription.html) |     |

#### IMyUseObject.HandleInput()

##### Declaration

```
bool IMyUseObject.HandleInput()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyUseObject.InstanceID

##### Declaration

```
int IMyUseObject.InstanceID { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IMyUseObject.InteractiveDistance

##### Declaration

```
float IMyUseObject.InteractiveDistance { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyUseObject.OnSelectionLost()

##### Declaration

```
void IMyUseObject.OnSelectionLost()
```

#### IMyUseObject.Owner

##### Declaration

```
IMyEntity IMyUseObject.Owner { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyUseObject.PlayIndicatorSound

##### Declaration

```
bool IMyUseObject.PlayIndicatorSound { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyUseObject.PrimaryAction

##### Declaration

```
UseActionEnum IMyUseObject.PrimaryAction { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [UseActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.UseActionEnum.html) |     |

#### IMyUseObject.RenderObjectID

##### Declaration

```
uint IMyUseObject.RenderObjectID { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |
