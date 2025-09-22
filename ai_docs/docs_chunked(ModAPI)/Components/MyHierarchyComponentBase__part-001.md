---
title: "Class MyHierarchyComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyHierarchyComponentBase"
---

# Class MyHierarchyComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyHierarchyComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyHierarchyComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyHierarchyComponentBase()

##### Declaration

```
public MyHierarchyComponentBase()
```

### Fields

#### ChildId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Properties

#### Children

Gets the children collection.

##### Declaration

```
public ListReader<MyHierarchyComponentBase> Children { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html)\> |     |

#### ChildrenNeedingWorldMatrix

Gets the children collection for spatial updates.

##### Declaration

```
public HashSetReader<MyHierarchyComponentBase> ChildrenNeedingWorldMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<[MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html)\> |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### Parent

##### Declaration

```
public MyHierarchyComponentBase Parent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html) |     |

### Methods

#### AddChild(IMyEntity, Boolean, Boolean)

Adds the child.

##### Declaration

```
public void AddChild(IMyEntity child, bool preserveWorldPos = false, bool insertIntoSceneIfNeeded = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | child | The child. |
| System.Boolean | preserveWorldPos | if set to `true` \[preserve absolute position\]. |
| System.Boolean | insertIntoSceneIfNeeded |     |

#### AddChildWithMatrix(IMyEntity, ref Matrix, Boolean)

##### Declaration

```
public void AddChildWithMatrix(IMyEntity child, ref Matrix childLocalMatrix, bool insertIntoSceneIfNeeded = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | child |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | childLocalMatrix |     |
| System.Boolean | insertIntoSceneIfNeeded |     |

#### Delete()

##### Declaration

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### GetChildrenRecursive(HashSet<IMyEntity>)

##### Declaration

```
public void GetChildrenRecursive(HashSet<IMyEntity> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | result |     |

#### GetTopMostParent(Type)

Return top most parent of this entity

##### Declaration

```
public MyHierarchyComponentBase GetTopMostParent(Type type = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html) |     |

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnAddedToScene()

##### Declaration

```
public override void OnAddedToScene()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### RemoveByJN(MyHierarchyComponentBase)

##### Declaration

```
public void RemoveByJN(MyHierarchyComponentBase childHierarchy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html) | childHierarchy |     |

#### RemoveChild(IMyEntity, Boolean)

Removes the child.

##### Declaration

```
public void RemoveChild(IMyEntity child, bool preserveWorldPos = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | child | The child. |
| System.Boolean | preserveWorldPos | if set to `true` \[preserve absolute position\]. |
