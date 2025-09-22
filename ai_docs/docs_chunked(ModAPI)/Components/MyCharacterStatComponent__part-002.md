#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | objectBuilder |     |

##### Overrides

#### DoDamage(Single, Object)

##### Declaration

```
public void DoDamage(float damage, object statChangeData = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| System.Object | statChangeData |     |

#### GetAccumulatedDelta()

Gets accumulated incoming value change (before clamping and immunities) and resets it

##### Declaration

```
public float GetAccumulatedDelta()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnHealthChanged(Single, Single, Object)

##### Declaration

```
public void OnHealthChanged(float newHealth, float oldHealth, object statChangeData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | newHealth |     |
| System.Single | oldHealth |     |
| System.Object | statChangeData |     |

#### SendStatChangeNotification(String, String, Single)

##### Declaration

```
public void SendStatChangeNotification(string text, string font, float durationSeconds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | text |     |
| System.String | font |     |
| System.Single | durationSeconds |     |

#### TryGetScript<T>(out T)

##### Declaration

```
public bool TryGetScript<T>(out T script)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | script |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### UpdateAfterSimulationParallel()

##### Declaration

```
public override void UpdateAfterSimulationParallel()
```

##### Overrides

### Explicit Interface Implementations

#### IMyHazardReceiver.Apply(Single, MyStringHash, MyStringHash)

##### Declaration

```
void IMyHazardReceiver.Apply(float amount, MyStringHash statId, MyStringHash damageType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | amount |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | statId |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |

#### IMyHazardReceiver.CanBeAffected()

##### Declaration

```
bool IMyHazardReceiver.CanBeAffected()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyHazardReceiver.GetEntity()

##### Declaration

```
IMyEntity IMyHazardReceiver.GetEntity()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyEntity.html) |     |

#### IMyHazardReceiver.GetPosition()

##### Declaration

```
Vector3D IMyHazardReceiver.GetPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Implements

### Extension Methods