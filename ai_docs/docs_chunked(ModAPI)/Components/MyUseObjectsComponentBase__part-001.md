---
title: "Class MyUseObjectsComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyUseObjectsComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyUseObjectsComponentBase"
---

# Class MyUseObjectsComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyUseObjectsComponentBase

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyComponentType]
public abstract class MyUseObjectsComponentBase : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyUseObjectsComponentBase()

##### Declaration

```
protected MyUseObjectsComponentBase()
```

### Fields

#### m\_detectors

##### Declaration

```
protected Dictionary<string, List<Matrix>> m_detectors
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)\>> |     |

### Properties

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

#### DetectorPhysics

##### Declaration

```
public abstract MyPhysicsComponentBase DetectorPhysics { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html) |     |

### Methods

#### AddDetector(String, Matrix)

##### Declaration

```
public abstract uint AddDetector(string name, Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### ClearPhysics()

##### Declaration

```
public virtual void ClearPhysics()
```

#### GetDetectors(String)

##### Declaration

```
public ListReader<Matrix> GetDetectors(string detectorName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | detectorName |     |

##### Returns

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)\> |     |

#### GetDetectorTransformation(IMyUseObject)

##### Declaration

```
public abstract Nullable<MatrixD> GetDetectorTransformation(IMyUseObject useObject)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) | useObject |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> |     |

#### GetInteractiveObject(String)

##### Declaration

```
public abstract IMyUseObject GetInteractiveObject(string detectorName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | detectorName |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

#### GetInteractiveObject(UInt32)

##### Declaration

```
public abstract IMyUseObject GetInteractiveObject(uint shapeKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | shapeKey |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

#### GetInteractiveObjects<T>(List<T>)

##### Declaration

```
public abstract void GetInteractiveObjects<T>(List<T> objects)
    where T : class, IMyUseObject
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | objects |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### LoadDetectorsFromModel()

##### Declaration

```
public abstract void LoadDetectorsFromModel()
```

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

#### OnRemovedFromScene()

##### Declaration

```
public override void OnRemovedFromScene()
```

##### Overrides

#### PositionChanged(MyPositionComponentBase)

##### Declaration

```
public abstract void PositionChanged(MyPositionComponentBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPositionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html) | obj |     |

#### ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple<Single, Object>>, Vector3D, Vector3, Object)

##### Declaration

```
public virtual void ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple<float, object>> output, Vector3D from, Vector3 dir, object hit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<[IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html), System.Tuple<System.Single, System.Object\>> | output |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | dir |     |
| System.Object | hit |     |
