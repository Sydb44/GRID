| System.Int64 | identityId | Players IdentityId |
| System.Int32 | gpsHash | Hash of gps |
| System.Boolean | show | When true, gps should be shown on Hud |

#### SetShowOnHud(Int64, IMyGps, Boolean)

Sends a network request to set the GPS entry if it's shown on HUD or not.

##### Declaration

```
void SetShowOnHud(long identityId, IMyGps gps, bool show)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Players IdentityId |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | gps | GPS |
| System.Boolean | show | Shows on hud |