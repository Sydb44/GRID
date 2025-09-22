public void Set(MyIniKey key, long value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.Int64 | value |     |

#### Set(MyIniKey, SByte)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(MyIniKey key, sbyte value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.SByte | value |     |

#### Set(MyIniKey, Single)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(MyIniKey key, float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.Single | value |     |

#### Set(MyIniKey, String)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(MyIniKey key, string value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.String | value |     |

#### Set(MyIniKey, UInt16)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(MyIniKey key, ushort value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.UInt16 | value |     |

#### Set(MyIniKey, UInt32)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(MyIniKey key, uint value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.UInt32 | value |     |

#### Set(MyIniKey, UInt64)

Sets the value of the given configuration key.

##### Declaration

```
public void Set(MyIniKey key, ulong value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.UInt64 | value |     |

Sets a comment on a given item. The item must already exist. Set the comment to `null` to remove it.

##### Declaration

```
public void SetComment(string section, string name, string comment)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |
| System.String | comment |     |

Sets a comment on a given item. The item must already exist. Set the comment to `null` to remove it.

##### Declaration

```
public void SetComment(MyIniKey key, string comment)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |
| System.String | comment |     |

Sets a comment to be placed after the last section or item. Set the comment to `null` to remove it.

##### Declaration

```
public void SetEndComment(string comment)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | comment |     |

Sets a comment on a given section. The section must already exist. Set the comment to `null` to remove it.

##### Declaration

```
public void SetSectionComment(string section, string comment)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | comment |     |

#### ToString()

Generates a configuration file from the currently parsed configuration

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryParse(String)

Attempts to parse the given content as a configuration file.

##### Declaration

```
public bool TryParse(string content)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | content |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the parse succeeds, `false` otherwise |

#### TryParse(String, String)

Attempts to parse the given content as a configuration file. OBSERVE: Use only for read-only operations. If you parse a single section and run [ToString()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIni.html#VRage_Game_ModAPI_Ingame_Utilities_MyIni_ToString), you will only get the parsed section, the rest will be discarded.

##### Declaration

```
public bool TryParse(string content, string section)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | content |     |
| System.String | section | The specific section to parse. Any other section in the content will be ignored. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the parse succeeds, `false` otherwise |

#### TryParse(String, String, out MyIniParseResult)

Attempts to parse the given content as a configuration file. OBSERVE: Use only for read-only operations. If you parse a single section and run [ToString()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIni.html#VRage_Game_ModAPI_Ingame_Utilities_MyIni_ToString), you will only get the parsed section, the rest will be discarded.

##### Declaration

```
public bool TryParse(string content, string section, out MyIniParseResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | content |     |
| System.String | section | The specific section to parse. Any other section in the content will be ignored. |
| [MyIniParseResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult.html) | result | If unsuccessful, this value contains information about why the parse failed |
