| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if a section was deleted; `false` otherwise. |

#### Get(String, String)

Gets the [MyIniValue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html) of the given configuration key.

##### Declaration

```
public MyIniValue Get(string section, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyIniValue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html) |     |

#### Get(MyIniKey)

Gets the [MyIniValue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html) of the given configuration key.

##### Declaration

```
public MyIniValue Get(MyIniKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyIniValue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html) |     |

Gets any comment that might be associated with the given key. Returns `null` if the key does not exist or has no comment.

##### Declaration

```
public string GetComment(string section, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

Gets any comment that might be associated with the given key. Returns `null` if the key does not exist or has no comment.

##### Declaration

```
public string GetComment(MyIniKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetKeys(List<MyIniKey>)

Fills the provided list with all configuration keys within the currently parsed configuration.

##### Declaration

```
public void GetKeys(List<MyIniKey> keys)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)\> | keys |     |

#### GetKeys(String, List<MyIniKey>)

Fills the provided list with the configuration keys within the given section.

##### Declaration

```
public void GetKeys(string section, List<MyIniKey> keys)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.Collections.Generic.List<[MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)\> | keys |     |

Get any comment that might be associated with the given section. Returns `null` if the section does not exist or has no comment.

##### Declaration

```
public string GetSectionComment(string section)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetSections(List<String>)

Fills the provided list with the names of all the sections in the currently parsed configuration.

##### Declaration

```
public void GetSections(List<string> names)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | names |     |

#### HasSection(String, String)

Determines if the given configuration contains what looks like the given section. It does not verify that the content is actually in a valid format, just if there's a line starting with \[section\].

##### Declaration

```
public static bool HasSection(string config, string section)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | config |     |
| System.String | section |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Invalidate()

Forces regeneration of the ini content. Only really useful if you want to reformat the configuration file.

##### Declaration

#### Set(String, String, Boolean)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(string section, string name, bool value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |
| System.Boolean | value |     |

#### Set(String, String, Byte)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(string section, string name, byte value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |
| System.Byte | value |     |

#### Set(String, String, Decimal)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(string section, string name, Decimal value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |
| System.Decimal | value |     |

#### Set(String, String, Double)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(string section, string name, double value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |
| System.Double | value |     |
