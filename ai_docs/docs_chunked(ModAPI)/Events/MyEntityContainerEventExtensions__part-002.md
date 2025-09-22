##### Declaration

```
public static void RegisterForEntityEvent(this MyEntityComponentBase component, MyStringHash eventType, MyEntityContainerEventExtensions.EntityEventHandler handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html) | component | Component that is being registered |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | eventType | type of event |
| [MyEntityContainerEventExtensions.EntityEventHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityContainerEventExtensions.EntityEventHandler.html) | handler | handler to be called |

#### SkipProcessingEvents(Boolean)

##### Declaration

```
public static void SkipProcessingEvents(bool state)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | state |     |

#### UnregisterForEntityEvent(MyEntityComponentBase, MyEntity, MyStringHash)

This will unregister the component to listen to some events on entity that is other than entity containing this component

##### Declaration

```
public static void UnregisterForEntityEvent(this MyEntityComponentBase component, MyEntity entity, MyStringHash eventType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html) | component | Component that is being registered |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity | Entity on which we listen to events |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | eventType | type of event |