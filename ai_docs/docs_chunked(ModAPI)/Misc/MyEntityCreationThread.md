---
title: "Class MyEntityCreationThread"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityCreationThread.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntityCreationThread"
---

# Class MyEntityCreationThread | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityCreationThread

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyEntityCreationThread : Object, IDisposable
```

### Constructors

#### MyEntityCreationThread()

##### Declaration

```
public MyEntityCreationThread()
```

### Properties

#### AnyResult

##### Declaration

```
public bool AnyResult { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ConsumeResult(MyTimeSpan)

##### Declaration

```
public bool ConsumeResult(MyTimeSpan timestamp)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTimeSpan](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyTimeSpan.html) | timestamp |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Dispose()

##### Declaration

#### ReleaseWaiting(Byte, Dictionary<Int64, MatrixD>)

##### Declaration

```
public void ReleaseWaiting(byte index, Dictionary<long, MatrixD> matrices)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | index |     |
| System.Collections.Generic.Dictionary<System.Int64, [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> | matrices |     |

#### SubmitWork(MyObjectBuilder\_EntityBase, Boolean, Action<MyEntity>, MyEntity, Byte, Double, Boolean)

##### Declaration

```
public void SubmitWork(MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<MyEntity> doneHandler, MyEntity entity = null, byte waitGroup = 0, double serializationTimestamp = 0, bool fadeIn = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |
| System.Boolean | addToScene |     |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | doneHandler |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Byte | waitGroup |     |
| System.Double | serializationTimestamp |     |
| System.Boolean | fadeIn |     |