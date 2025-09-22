---
title: "Class MyUseObjectsComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyUseObjectsComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyUseObjectsComponent"
---

# Class MyUseObjectsComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyUseObjectsComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyUseObjectsComponent : MyUseObjectsComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyUseObjectsComponent()

##### Declaration

```
public MyUseObjectsComponent()
```

### Fields

#### DetectorInteractiveObjects

##### Declaration

```
public readonly Dictionary<uint, MyUseObjectsComponent.DetectorData> DetectorInteractiveObjects
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.UInt32, [MyUseObjectsComponent.DetectorData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyUseObjectsComponent.DetectorData.html)\> |     |

### Properties

#### DetectorPhysics

##### Declaration

```
public override MyPhysicsComponentBase DetectorPhysics { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html) |     |

##### Overrides

### Methods

#### AddDetector(String, Matrix)

##### Declaration

```
public override uint AddDetector(string name, Matrix dummyMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | dummyMatrix |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

##### Overrides

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

#### GetDetectorTransformation(IMyUseObject)

##### Declaration

```
public override Nullable<MatrixD> GetDetectorTransformation(IMyUseObject useObject)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) | useObject |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> |     |

##### Overrides

#### GetInteractiveObject(String)

##### Declaration

```
public override IMyUseObject GetInteractiveObject(string detectorName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | detectorName |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

##### Overrides

#### GetInteractiveObject(UInt32)

##### Declaration

```
public override IMyUseObject GetInteractiveObject(uint shapeKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | shapeKey |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

##### Overrides

#### GetInteractiveObjects<T>(List<T>)

##### Declaration

```
public override void GetInteractiveObjects<T>(List<T> objects)
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

##### Overrides

VRage.Game.Components.MyUseObjectsComponentBase.GetInteractiveObjects<T>(System.Collections.Generic.List<T>)

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

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

#### LoadDetectorsFromModel()

##### Declaration

```
public override void LoadDetectorsFromModel()
```

##### Overrides

#### OnAddedToScene()

##### Declaration

```
public override void OnAddedToScene()
```

##### Overrides

#### PositionChanged(MyPositionComponentBase)

##### Declaration

```
public override void PositionChanged(MyPositionComponentBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPositionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html) | obj |     |

##### Overrides

#### ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple<Single, Object>>, Vector3D, Vector3, Object)

##### Declaration

```
public override void ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple<float, object>> output, Vector3D from, Vector3 dir, object hit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<[IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html), System.Tuple<System.Single, System.Object\>> | output |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | dir |     |
| System.Object | hit |     |
