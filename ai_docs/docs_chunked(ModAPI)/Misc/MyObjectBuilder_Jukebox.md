---
title: "Class MyObjectBuilder\\_Jukebox"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_Jukebox.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_Jukebox"
---

# Class MyObjectBuilder\_Jukebox | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Jukebox

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Jukebox : MyObjectBuilder_SoundBlock
```

### Constructors

#### MyObjectBuilder\_Jukebox()

##### Declaration

```
public MyObjectBuilder_Jukebox()
```

### Fields

#### CurrentSound

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsJukeboxPlaying

##### Declaration

```
public bool IsJukeboxPlaying
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SelectedSounds

##### Declaration

```
[Nullable]
public List<string> SelectedSounds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### TextPanels

##### Declaration

```
[Serialize]
public List<MySerializedTextPanelData> TextPanels
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

### Methods

#### GetTextPanelsData()

##### Declaration

```
public override List<MySerializedTextPanelData> GetTextPanelsData()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MySerializedTextPanelData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MySerializedTextPanelData.html)\> |     |

##### Overrides

### Extension Methods