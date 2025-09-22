---
title: "Class MyInstancedRenderSector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyInstancedRenderSector.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyInstancedRenderSector"
---

# Class MyInstancedRenderSector | Space Engineers ModAPI

##### Inheritance

System.Object

MyInstancedRenderSector

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyInstancedRenderSector : Object
```

### Constructors

#### MyInstancedRenderSector(String, MatrixD)

##### Declaration

```
public MyInstancedRenderSector(string name, MatrixD worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |

### Fields

#### WorldMatrix

##### Declaration

```
public MatrixD WorldMatrix
```

##### Field Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Properties

#### Lod

##### Declaration

```
public int Lod { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### AddInstance(Int32, ref MyInstanceData)

##### Declaration

```
public short AddInstance(int modelId, ref MyInstanceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | modelId |     |
| VRage.MyInstanceData | data |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### AddInstances(Int32, MyList<MyInstanceData>)

##### Declaration

```
public int AddInstances(int model, MyList<MyInstanceData> instances)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | model |     |
| VRage.Library.Collections.MyList<VRage.MyInstanceData\> | instances |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Close()

##### Declaration

#### CommitChangesToRenderer()

##### Declaration

```
public void CommitChangesToRenderer()
```

#### DetachEnvironment(MyEnvironmentSector)

##### Declaration

```
public void DetachEnvironment(MyEnvironmentSector myEnvironmentSector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEnvironmentSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSector.html) | myEnvironmentSector |     |

#### GetRenderEntity(Int32)

##### Declaration

```
public uint GetRenderEntity(int modelId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | modelId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### HasChanges()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveInstance(Int32, Int16)

##### Declaration

```
public void RemoveInstance(int modelId, short index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | modelId |     |
| System.Int16 | index |     |