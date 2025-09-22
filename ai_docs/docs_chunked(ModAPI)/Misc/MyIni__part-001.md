---
title: "Class MyIni"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIni.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame.Utilities"
class: "MyIni"
---

# Class MyIni | Space Engineers ModAPI

A configuration class to parse and create a text string resembling the old fashioned INI format, but with support for multiline values.

Do not forget that parsing is a time-consuming task. Keep your parsing to a minimum.

##### Inheritance

System.Object

MyIni

###### **Namespace**: [VRage.Game.ModAPI.Ingame.Utilities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyIni : Object
```

##### **Examples**

Using MyIni to deal with CustomData end-user configuration:

The CustomData:

```
[kernel]
output=DebugTextPanel
bootText=
|-- HAL9000 --
|Good morning, Dave.
```

The code:

```
MyIni _ini = new MyIni();
IMyTextPanel _outputTextPanel;
public Program()
{
MyIniParseResult result;
if (!_ini.TryParse(Me.CustomData, out result)
{
Echo($"CustomData error:\nLine {result}");
}
// Get the kernel section's output value. If this value is set, the system attempts
// to retrieve a text panel with the value set. Otherwise output is ignored.
var name = _ini.Get("kernel", "output").ToString();
if (name != null)
{
_outputTextPanel = GridTerminalSystem.GetBlockWithName<IMyTextPanel>(name);
if (_outputTextPanel == null)
Echo($"No text panel named {name}");
}
// Get the kernel section's boottext value. If no value is given, a default value will be returned.
var bootText = _ini.Get("kernel", "bootText").ToString("Kernel is starting up...");
_outputTextPanel?.WritePublicText(bootText);
}
```

Using MyIni to deal with internal storage:

```
MyIni _storage = new MyIni();
Vector3D _startupPosition;
bool _hasTarget;
Vector3D _currentTarget;
public Program()
{
// You only need to parse here in the constructor.
if (_ini.TryParse(Storage)
{
var str = _ini.Get("state", "startupPosition").ToString();
Vector3D.TryParse(str, out _startupPosition);
str = _ini.Get("state", "currentTarget").ToString();
Vector3D.TryParse(str, out _currentTarget);
_hasTarget = _ini.Get("state", "hasTarget").ToBoolean();
}
else
{
// Set up defaults, the storage is nonexistent or corrupt
_startupPosition = Me.CubeGrid.Position;
}
}
public void Save()
{
// You only need to update Storage when the Save method is called.
_ini.Set("state", "startupPosition", _startupPosition);
_ini.Set("state", "currentTarget", _currentTarget);
Storage = _ini.ToString();
}
```

### Constructors

#### MyIni()

##### Declaration

### Properties

Get or set a comment to be placed after the last section or item. Is `null` if the section does not exist or has no comment.

##### Declaration

```
public string EndComment { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### EndContent

You can terminate a configuration stream by entering "---" on a separate line. This property will contain all the content after this line.

##### Declaration

```
public string EndContent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### AddSection(String)

Adds an empty section

##### Declaration

```
public void AddSection(string section)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |

#### Clear()

Empties this configuration

##### Declaration

#### ContainsKey(String, String)

Determines whether a configuration key (section/key) exists in the currently parsed configuration.

##### Declaration

```
public bool ContainsKey(string section, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ContainsKey(MyIniKey)

Determines whether a configuration key (section/key) exists in the currently parsed configuration.

##### Declaration

```
public bool ContainsKey(MyIniKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ContainsSection(String)

Determines whether a section of a given name exists in the currently parsed configuration.

##### Declaration

```
public bool ContainsSection(string section)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Delete(String, String)

Deletes the given configuration key.

##### Declaration

```
public void Delete(string section, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |
| System.String | name |     |

#### Delete(MyIniKey)

Deletes the given configuration key.

##### Declaration

```
public void Delete(MyIniKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html) | key |     |

#### DeleteSection(String)

Deletes an entire selection

##### Declaration

```
public bool DeleteSection(string section)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | section |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if a section was deleted; `false` otherwise. |

#### Get(String, String)

Gets the [MyIniValue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html) of the given configuration key.
