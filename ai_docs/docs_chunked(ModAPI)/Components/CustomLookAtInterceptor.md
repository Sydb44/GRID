---
title: "Class CustomLookAtInterceptor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.CustomLookAtInterceptor.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "CustomLookAtInterceptor"
---

# Class CustomLookAtInterceptor | Space Engineers ModAPI

##### Inheritance

System.Object

CustomLookAtInterceptor

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class CustomLookAtInterceptor : MulticastDelegate
```

### Constructors

#### CustomLookAtInterceptor(Object, IntPtr)

##### Declaration

```
public CustomLookAtInterceptor(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Nullable<Vector3D>, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(Nullable<Vector3D> current, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | current |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual Nullable<Vector3D> EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### Invoke(Nullable<Vector3D>)

##### Declaration

```
public virtual Nullable<Vector3D> Invoke(Nullable<Vector3D> current)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | current |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |