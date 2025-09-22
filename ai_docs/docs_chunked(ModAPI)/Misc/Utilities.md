---
title: "Namespace VRage.Game.ModAPI.Ingame.Utilities"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "Utilities"
---

# Namespace VRage.Game.ModAPI.Ingame.Utilities | Space Engineers ModAPI

### Classes

#### [MyCommandLine](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.html)

A utility class to parse arguments from a command line string. Switches are defined with hyphen (-switch). Quotes can be placed around an argument to parse verbatim, but inner quotes will be copied verbatim. For example, "one"two" will result in the string one"two.

#### [MyCommandLine.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.Enumerator.html)

#### [MyCommandLine.ItemCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.ItemCollection.html)

A collection of arguments

#### [MyCommandLine.SwitchCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.SwitchCollection.html)

A collection of set switches

#### [MyCommandLine.SwitchEnumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine.SwitchEnumerator.html)

#### [MyIni](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIni.html)

A configuration class to parse and create a text string resembling the old fashioned INI format, but with support for multiline values.

Do not forget that parsing is a time-consuming task. Keep your parsing to a minimum.

#### [MyIniKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniKey.html)

Represents the combination of a section and a key in a [MyIni](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIni.html) structure.

#### [MyIniParseResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult.html)

Represents the results of a configuration parsing.

#### [MyIniValue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.html)

Represents the value of a single configuration item.

#### [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html)

Represents a segment of a string.

#### [StringSegmentComparer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.html)

A comparer designed to compare [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) instances in a case sensitive manner. Use [DEFAULT](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentComparer_DEFAULT) for a default instance

#### [StringSegmentIgnoreCaseComparer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.html)

A comparer designed to compare [StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html) instances in a case insensitive manner. Use [DEFAULT](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegmentIgnoreCaseComparer.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegmentIgnoreCaseComparer_DEFAULT) for a default instance

#### [TextPtr](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.TextPtr.html)

A parser utility structure representing a pointer to a location within a string.