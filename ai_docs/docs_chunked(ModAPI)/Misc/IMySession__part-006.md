```
void Update(MyTimeSpan time)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | time | Used in counting whether game save is required. Usually it is 16.67ms |

#### [](#VRage_Game_ModAPI_IMySession_UpdateComponents)UpdateComponents()

Updates games. Does 1 simulation tick, but without any other logic, that is executed in [Update(MyTimeSpan)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_Update_VRage_Library_Utils_MyTimeSpan_)

##### Declaration

### [](#events)Events

#### [](#VRage_Game_ModAPI_IMySession_OnSessionLoading)OnSessionLoading

Called when session started loading

##### Declaration

```
event Action OnSessionLoading
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### [](#VRage_Game_ModAPI_IMySession_OnSessionReady)OnSessionReady

Called when session is ready

##### Declaration

```
event Action OnSessionReady
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |