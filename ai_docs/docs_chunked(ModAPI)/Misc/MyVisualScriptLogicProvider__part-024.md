Description

System.Collections.Generic.List<System.Single\>

#### LoadEntityInteger(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads integer from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static int LoadEntityInteger(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Int32

#### LoadEntityIntegerList(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads integer list from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<int> LoadEntityIntegerList(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Collections.Generic.List<System.Int32\>

#### LoadEntityLong(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads long integer from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static long LoadEntityLong(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Int64

#### LoadEntityLongList(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads long list from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> LoadEntityLongList(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### LoadEntityString(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads string from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static string LoadEntityString(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.String

#### LoadEntityStringList(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads string list from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<string> LoadEntityStringList(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Collections.Generic.List<System.String\>

#### LoadEntityVector(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads Vector3D (doubles) from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3D LoadEntityVector(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### LoadEntityVectorList(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads Vector3D (doubles) from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<Vector3D> LoadEntityVectorList(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Collections.Generic.List<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### MusicPlayMusicCategory(String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Sets currently selected category to specific category and play a track from it.", -10510688)]
[VisualScriptingMember(true, false)]
public static void MusicPlayMusicCategory(string categoryName, bool playAtLeastOnce = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

categoryName

System.Boolean

playAtLeastOnce

System.Int64

playerId

#### MusicPlayMusicCategoryLocal(String, Boolean)

##### Declaration

```
public static void MusicPlayMusicCategoryLocal(string categoryName, bool playAtLeastOnce = true)
```

##### Parameters

Type

Name

Description

System.String

categoryName

System.Boolean

playAtLeastOnce

#### MusicPlayMusicCue(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Plays specific music cue.", -10510688)]
[VisualScriptingMember(true, false)]
public static void MusicPlayMusicCue(string cueName, bool playAtLeastOnce = true)
```

##### Parameters

Type

Name

Description

System.String

cueName

System.Boolean

playAtLeastOnce

#### MusicPlayMusicCueLocal(String, Boolean)

##### Declaration

```
public static void MusicPlayMusicCueLocal(string cueName, bool playAtLeastOnce = true)
```

##### Parameters

Type

Name

Description

System.String

cueName

System.Boolean

playAtLeastOnce

#### MusicSetDynamicMusic(Boolean)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Enables/disables dynamic music category changes.", -10510688)]
[VisualScriptingMember(true, false)]
public static void MusicSetDynamicMusic(bool enabled)
```

##### Parameters

Type

Name

Description

System.Boolean

enabled

#### MusicSetDynamicMusicLocal(Boolean)

##### Declaration

```
public static void MusicSetDynamicMusicLocal(bool enabled)
```

##### Parameters

Type

Name

Description

System.Boolean

enabled

#### MusicSetMusicCategory(String)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Sets currently selected category to specific music category.", -10510688)]
[VisualScriptingMember(true, false)]
public static void MusicSetMusicCategory(string categoryName)
```

##### Parameters

Type

Name

Description

System.String

categoryName

#### MusicSetMusicCategoryLocal(String)
