System.Int64

playerId

#### CreateExplosion(Vector3D, Single, Int32)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Creates explosion at specific point with specified radius, causing damage to everything in range.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateExplosion(Vector3D position, float radius, int damage = 5000)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

radius

System.Int32

damage

#### CreateFaction(Int64, String, String, String, String)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Creates new faction.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateFaction(long founderId, string factionTag, string factionName = "", string factionDescription = "", string factionPrivateText = "")
```

##### Parameters

Type

Name

Description

System.Int64

founderId

System.String

factionTag

System.String

factionName

System.String

factionDescription

System.String

factionPrivateText

#### CreateLightning(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Creates lightning on exact position", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateLightning(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### CreateLightning(Vector3D, Single, Byte, Int16, Single, Int16, Int32)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Summons lightning on a position", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateLightning(Vector3D position, float boltLength, byte boltParts, short boltVariation, float boltRadius, short maxLife, int damage)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

boltLength

System.Byte

boltParts

System.Int16

boltVariation

System.Single

boltRadius

System.Int16

maxLife

System.Int32

damage

#### CreateLocalBlueprint(String, String, String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Creates local blueprint for player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateLocalBlueprint(string gridName, string blueprintName, string blueprintDisplayName = null)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.String

blueprintName

System.String

blueprintDisplayName

#### CreateParticleEffectAtEntity(String, String)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Creates specific particle effect at entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateParticleEffectAtEntity(string effectName, string entityName)
```

##### Parameters

Type

Name

Description

System.String

effectName

System.String

entityName

#### CreateParticleEffectAtPosition(String, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Creates specific particle effect at position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateParticleEffectAtPosition(string effectName, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

effectName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### CreateSoundEmitterAtEntity(String, String)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Creates new 3D sound emitter at entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateSoundEmitterAtEntity([Nullable] string newEmitterId, string entityName)
```

##### Parameters

Type

Name

Description

System.String

newEmitterId

System.String

entityName

#### CreateSoundEmitterAtEntityLocal(String, String)

##### Declaration

```
public static void CreateSoundEmitterAtEntityLocal(string newEmitterId, string entityName)
```

##### Parameters

Type

Name

Description

System.String

newEmitterId

System.String

entityName

#### CreateSoundEmitterAtPosition(String, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Creates new 3D sound emitter at specific location.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateSoundEmitterAtPosition([Nullable] string newEmitterId, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

newEmitterId

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### CreateSoundEmitterAtPositionLocal(String, Vector3D)

##### Declaration

```
public static void CreateSoundEmitterAtPositionLocal([Nullable] string newEmitterId, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

newEmitterId

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### CreateUIString(Int64, String, Single, Single, Single, String, MyGuiDrawAlignEnum, Int64)

##### Declaration

```
[VisualScriptingMiscData("UIString", "Create UI string on specific coordinates. PlayerId -1 stands for all players, 0 for local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateUIString(long id, string text, float normalizedXPos, float normalizedYPos, float scale = 1F, string font = "White", MyGuiDrawAlignEnum drawAlign, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

id

System.String

text

System.Single

normalizedXPos

System.Single

normalizedYPos

System.Single

scale

System.String

font

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

drawAlign

System.Int64

playerId

#### CustomRespawnRequest(Int64)

##### Declaration

```
public static void CustomRespawnRequest(long playerId)
```
