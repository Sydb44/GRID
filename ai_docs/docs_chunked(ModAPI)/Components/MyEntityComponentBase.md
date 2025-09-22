---
title: "Class MyEntityComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyEntityComponentBase"
---

# Class MyEntityComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyEntityComponentBase : MyComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### [](#constructors)Constructors

#### [](#VRage_Game_Components_MyEntityComponentBase__ctor)MyEntityComponentBase()

##### Declaration

```
protected MyEntityComponentBase()
```

### [](#properties)Properties

#### [](#VRage_Game_Components_MyEntityComponentBase_AttachSyncToEntity)AttachSyncToEntity

##### Declaration

```
public virtual bool AttachSyncToEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_Components_MyEntityComponentBase_ComponentTypeDebugString)ComponentTypeDebugString

Name of the base component type for debug purposes (e.g.: "Position")

##### Declaration

```
public abstract string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_Components_MyEntityComponentBase_Container)Container

##### Declaration

```
public IMyEntityComponentContainer Container { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Components.Interfaces.IMyEntityComponentContainer |     |

#### [](#VRage_Game_Components_MyEntityComponentBase_Entity)Entity

##### Declaration

```
public IMyEntity Entity { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Game_Components_MyEntityComponentBase_OnAddedToContainer)OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### [](#VRage_Game_Components_MyEntityComponentBase_OnBeforeRemovedFromContainer)OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

### [](#events)Events

#### [](#VRage_Game_Components_MyEntityComponentBase_BeforeRemovedFromContainer)BeforeRemovedFromContainer

##### Declaration

```
public event Action<IMyEntityComponentBase> BeforeRemovedFromContainer
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<VRage.Game.Components.Interfaces.IMyEntityComponentBase\> |     |

#### [](#VRage_Game_Components_MyEntityComponentBase_OnAfterAddedToContainer)OnAfterAddedToContainer

##### Declaration

```
public static event Action<MyEntityComponentBase> OnAfterAddedToContainer
```

##### Event Type

### [](#extensionmethods)Extension Methods