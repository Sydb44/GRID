
```
public void SetTimer(float timeMin, Action<IMyEntityComponentContainer> triggerEvent, bool start = true, bool repeat = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | timeMin |     |
| System.Action<VRage.Game.Components.Interfaces.IMyEntityComponentContainer\> | triggerEvent |     |
| System.Boolean | start |     |
| System.Boolean | repeat |     |

#### SetTimer(UInt32, Action<IMyEntityComponentContainer>, Boolean, Boolean)

##### Declaration

```
public void SetTimer(uint timeTickInFrames, Action<IMyEntityComponentContainer> triggerEvent, bool start = true, bool repeat = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | timeTickInFrames |     |
| System.Action<VRage.Game.Components.Interfaces.IMyEntityComponentContainer\> | triggerEvent |     |
| System.Boolean | start |     |
| System.Boolean | repeat |     |

#### SetType(MyTimerTypes)

##### Declaration

```
public void SetType(MyTimerTypes type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimerTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyTimerTypes.html) | type |     |

#### Update(Boolean)

##### Declaration

```
public void Update(bool forceUpdate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | forceUpdate |     |

### Extension Methods