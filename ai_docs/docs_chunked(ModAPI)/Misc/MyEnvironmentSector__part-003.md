#### ReEnableSectorItem(Int32)

##### Declaration

```
public void ReEnableSectorItem(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

#### remove\_OnContactPoint(MySectorContactEvent)

##### Declaration

```
public void remove_OnContactPoint(MySectorContactEvent value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySectorContactEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MySectorContactEvent.html) | value |     |

#### SetLod(Int32)

##### Declaration

```
public void SetLod(int lod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

### Events

#### OnContactPoint

##### Declaration

```
public event MySectorContactEvent OnContactPoint
```

##### Event Type

| Type | Description |
| --- | --- |
| [MySectorContactEvent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MySectorContactEvent.html) |     |

#### OnLodCommit

##### Declaration

```
public event Action<MyEnvironmentSector, int> OnLodCommit
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html), System.Int32\> |     |

#### OnPhysicsClose

##### Declaration

```
public event Action OnPhysicsClose
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnPhysicsCommit

##### Declaration

```
public event Action<MyEnvironmentSector, bool> OnPhysicsCommit
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html), System.Boolean\> |     |

### Implements

### Extension Methods