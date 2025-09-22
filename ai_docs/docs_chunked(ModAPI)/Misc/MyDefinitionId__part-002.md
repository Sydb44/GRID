Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder\_Ore/Iron". The first part must represent an existing type. If it does not, an exception will be thrown. The second (the subtype) is not enforced. See TryParse for a parsing method that does not throw an exception.

##### Declaration

```
public static MyDefinitionId Parse(string id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryParse(String, String, out MyDefinitionId)

##### Declaration

```
public static bool TryParse(string type, string subtype, out MyDefinitionId definitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | type |     |
| System.String | subtype |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | definitionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryParse(String, out MyDefinitionId)

Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder\_Ore/Iron". The first part must represent an existing type, while the second (the subtype) is not enforced.

##### Declaration

```
public static bool TryParse(string id, out MyDefinitionId definitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | definitionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Operators

#### Equality(MyDefinitionId, MyDefinitionId)

##### Declaration

```
public static bool operator ==(MyDefinitionId l, MyDefinitionId r)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | l   |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | r   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Implicit(MyDefinitionId to SerializableDefinitionId)

##### Declaration

```
public static implicit operator SerializableDefinitionId(MyDefinitionId v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) |     |

#### Implicit(SerializableDefinitionId to MyDefinitionId)

##### Declaration

```
public static implicit operator MyDefinitionId(SerializableDefinitionId v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### Inequality(MyDefinitionId, MyDefinitionId)

##### Declaration

```
public static bool operator !=(MyDefinitionId l, MyDefinitionId r)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | l   |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | r   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |