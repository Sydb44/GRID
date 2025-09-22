#### SpawnRadius

##### Declaration

```
public float SpawnRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase baseBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | baseBuilder |     |

##### Overrides

#### ReloadPrefabs()

##### Declaration

```
public void ReloadPrefabs()
```

#### TryGetOwnerId(out Int64, Boolean)

##### Declaration

```
public bool TryGetOwnerId(out long ownerId, bool isGlobalSubEncounter = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | ownerId | result ownerId for this group |
| System.Boolean | isGlobalSubEncounter | marks if spawn groups is spawning as global sub encounter |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if target faction was found, false otherwise |