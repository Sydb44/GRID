| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### SetValue(Guid, String)

Stores a value with the specified key into the Storage dictionary.

##### Declaration

```
public abstract void SetValue(Guid guid, string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |
| System.String | value |     |

#### TryGetValue(Guid, out String)

Tries to a value from the Storage dictionary with the specified key.

##### Declaration

```
public abstract bool TryGetValue(Guid guid, out string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | guid |     |
| System.String | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | **true** on success; **false** on failure |

### Extension Methods