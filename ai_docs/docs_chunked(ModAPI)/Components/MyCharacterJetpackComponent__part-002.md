##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Running

##### Declaration

```
public bool Running { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TurnedOn

##### Declaration

```
public bool TurnedOn { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ClearMovement()

##### Declaration

```
public void ClearMovement()
```

#### EnableDampeners(Boolean)

##### Declaration

```
public void EnableDampeners(bool enable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enable |     |

#### GetObjectBuilder(MyObjectBuilder\_Character)

##### Declaration

```
public virtual void GetObjectBuilder(MyObjectBuilder_Character characterBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Character](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Character.html) | characterBuilder |     |

#### Init(MyObjectBuilder\_Character)

##### Declaration

```
public virtual void Init(MyObjectBuilder_Character characterBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Character](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Character.html) | characterBuilder |     |

#### MoveAndRotate(ref Vector3, ref Vector2, Single, Boolean)

##### Declaration

```
public void MoveAndRotate(ref Vector3 moveIndicator, ref Vector2 rotationIndicator, float roll, bool canRotate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | moveIndicator |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator |     |
| System.Single | roll |     |
| System.Boolean | canRotate |     |

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnCharacterDead()

##### Declaration

```
public void OnCharacterDead()
```

#### SwitchDamping()

##### Declaration

```
public void SwitchDamping()
```

#### SwitchThrusts()

##### Declaration

```
public void SwitchThrusts()
```

#### TurnOnJetpack(Boolean, Boolean, Boolean)

##### Declaration

```
public void TurnOnJetpack(bool newState, bool fromInit = false, bool fromLoad = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | newState |     |
| System.Boolean | fromInit |     |
| System.Boolean | fromLoad |     |

#### UpdateFall()

##### Declaration

#### UpdatePhysicalMovement()

##### Declaration

```
public bool UpdatePhysicalMovement()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UpdateSimulate()

##### Declaration

```
public override void UpdateSimulate()
```

##### Overrides

### Implements

### Extension Methods