```
public bool PlaySingleSound(MySoundPair soundId, bool stopPrevious = false, bool skipIntro = false, bool skipToEnd = false, Nullable<bool> force3D = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) | soundId |     |
| System.Boolean | stopPrevious |     |
| System.Boolean | skipIntro |     |
| System.Boolean | skipToEnd |     |
| System.Nullable<System.Boolean\> | force3D |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlaySingleSound(MyCueId, Boolean, Boolean, Nullable<Boolean>)

##### Declaration

```
public void PlaySingleSound(MyCueId soundId, bool stopPrevious = false, bool skipIntro = false, Nullable<bool> force3D = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Audio.MyCueId | soundId |     |
| System.Boolean | stopPrevious |     |
| System.Boolean | skipIntro |     |
| System.Nullable<System.Boolean\> | force3D |     |

#### PlaySound(MySoundPair, Boolean, Boolean, Boolean, Boolean, Boolean, Nullable<Boolean>, Boolean)

##### Declaration

```
public bool PlaySound(MySoundPair soundId, bool stopPrevious = false, bool skipIntro = false, bool force2D = false, bool alwaysHearOnRealistic = false, bool skipToEnd = false, Nullable<bool> force3D = null, bool forcePlaySound = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) | soundId |     |
| System.Boolean | stopPrevious |     |
| System.Boolean | skipIntro |     |
| System.Boolean | force2D |     |
| System.Boolean | alwaysHearOnRealistic |     |
| System.Boolean | skipToEnd |     |
| System.Nullable<System.Boolean\> | force3D |     |
| System.Boolean | forcePlaySound |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlaySound(Byte\[\], Single, Single, MySoundDimensions)

##### Declaration

```
public void PlaySound(byte[] buffer, float volume = 1F, float maxDistance = 0F, MySoundDimensions dimension)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | buffer |     |
| System.Single | volume |     |
| System.Single | maxDistance |     |
| VRage.Data.Audio.MySoundDimensions | dimension |     |

#### PlaySoundWithDistance(MyCueId, Boolean, Boolean, Boolean, Boolean, Boolean, Boolean, Nullable<Boolean>)

##### Declaration

```
public bool PlaySoundWithDistance(MyCueId soundId, bool stopPrevious = false, bool skipIntro = false, bool force2D = false, bool useDistanceCheck = true, bool alwaysHearOnRealistic = false, bool skipToEnd = false, Nullable<bool> force3D = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Audio.MyCueId | soundId |     |
| System.Boolean | stopPrevious |     |
| System.Boolean | skipIntro |     |
| System.Boolean | force2D |     |
| System.Boolean | useDistanceCheck |     |
| System.Boolean | alwaysHearOnRealistic |     |
| System.Boolean | skipToEnd |     |
| System.Nullable<System.Boolean\> | force3D |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PreloadSound(MySoundPair)

##### Declaration

```
public static void PreloadSound(MySoundPair soundId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) | soundId |     |

#### SetPosition(Nullable<Vector3D>)

##### Declaration

```
public void SetPosition(Nullable<Vector3D> position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | position |     |

#### SetSound(IMySourceVoice, String)

##### Declaration

```
public void SetSound(IMySourceVoice value, string caller = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Audio.IMySourceVoice | value |     |
| System.String | caller |     |

#### SetVelocity(Nullable<Vector3>)

##### Declaration

```
public void SetVelocity(Nullable<Vector3> velocity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | velocity |     |

#### StopSound(Boolean, Boolean, Boolean)

##### Declaration

```
public void StopSound(bool forced, bool cleanUp = true, bool cleanupSound = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | forced |     |
| System.Boolean | cleanUp |     |
| System.Boolean | cleanupSound |     |

#### Update()

##### Declaration

#### UpdateEntityEmitters(Boolean, Boolean, Boolean)

##### Declaration

```
public static void UpdateEntityEmitters(bool removeUnused, bool updatePlaying, bool updateNotPlaying)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | removeUnused |     |
| System.Boolean | updatePlaying |     |
| System.Boolean | updateNotPlaying |     |

### Events

#### StoppedPlaying

##### Declaration

```
public event Action<MyEntity3DSoundEmitter> StoppedPlaying
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyEntity3DSoundEmitter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntity3DSoundEmitter.html)\> |     |