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

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the parse succeeds, `false` otherwise |

#### TryParse(String, out MyIniParseResult)

Attempts to parse the given content as a configuration file.

##### Declaration

```
public bool TryParse(string content, out MyIniParseResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | content |     |
| [MyIniParseResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult.html) | result | If unsuccessful, this value contains information about why the parse failed |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the parse succeeds, `false` otherwise |