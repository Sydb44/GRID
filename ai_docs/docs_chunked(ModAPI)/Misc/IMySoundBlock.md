---
title: "Interface IMySoundBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMySoundBlock.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMySoundBlock"
---

# Interface IMySoundBlock | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMySoundBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### IsSoundSelected

Gets if a sound is currently selected.

##### Declaration

```
bool IsSoundSelected { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LoopPeriod

Gets or sets the loop period of a loopable sound, in seconds.

##### Declaration

```
float LoopPeriod { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Range

Gets or sets the range the sound is audible.

##### Declaration

```
float Range { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SelectedSound

Gets or sets the selected sound.

##### Declaration

```
string SelectedSound { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Volume

Gets or sets the volume level of sound

##### Declaration

```
float Volume { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetSounds(List<String>)

Gets a list of all sound IDs this block can use.

##### Declaration

```
void GetSounds(List<string> sounds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | sounds |     |

#### Play()

Plays the currently selected sound.

##### Declaration

#### Stop()

Stops the currently playing sound.

##### Declaration

### Extension Methods