---
title: "Class MyVoxelBase.OnCutOutResults"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.OnCutOutResults.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyVoxelBase"
class: "OnCutOutResults"
---

# Class MyVoxelBase.OnCutOutResults | Space Engineers ModAPI

##### Inheritance

System.Object

MyVoxelBase.OnCutOutResults

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class OnCutOutResults : MulticastDelegate
```

### Constructors

#### OnCutOutResults(Object, IntPtr)

##### Declaration

```
public OnCutOutResults(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Single, MyVoxelMaterialDefinition, Dictionary<MyVoxelMaterialDefinition, Int32>, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(float voxelsCountInPercent, MyVoxelMaterialDefinition voxelMaterial, Dictionary<MyVoxelMaterialDefinition, int> exactCutOutMaterials, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | voxelsCountInPercent |     |
| [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html) | voxelMaterial |     |
| System.Collections.Generic.Dictionary<[MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html), System.Int32\> | exactCutOutMaterials |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### Invoke(Single, MyVoxelMaterialDefinition, Dictionary<MyVoxelMaterialDefinition, Int32>)

##### Declaration

```
public virtual void Invoke(float voxelsCountInPercent, MyVoxelMaterialDefinition voxelMaterial, Dictionary<MyVoxelMaterialDefinition, int> exactCutOutMaterials)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | voxelsCountInPercent |     |
| [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html) | voxelMaterial |     |
| System.Collections.Generic.Dictionary<[MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html), System.Int32\> | exactCutOutMaterials |     |