
##### Declaration

```
public void RemoveChild(IMyEntity child, bool preserveWorldPos = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | child | The child. |
| System.Boolean | preserveWorldPos | if set to `true` \[preserve absolute position\]. |

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

### Events

#### OnChildRemoved

##### Declaration

```
public event Action<IMyEntity> OnChildRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### OnParentChanged

##### Declaration

```
public event Action<MyHierarchyComponentBase, MyHierarchyComponentBase> OnParentChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html), [MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html)\> |     |

### Extension Methods