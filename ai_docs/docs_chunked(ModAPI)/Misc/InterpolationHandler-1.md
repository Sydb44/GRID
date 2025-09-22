---
title: "Class InterpolationHandler<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.InterpolationHandler-1.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "InterpolationHandler-1"
---

# Class InterpolationHandler<T> | Space Engineers ModAPI

##### Inheritance

System.Object

InterpolationHandler<T>

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class InterpolationHandler<T> : MulticastDelegate
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### InterpolationHandler(Object, IntPtr)

##### Declaration

```
public InterpolationHandler(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(T, T, Single, out T, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(T item1, T item2, float interpolator, out T result, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item1 |     |
| T   | item2 |     |
| System.Single | interpolator |     |
| T   | result |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(out T, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(out T result, IAsyncResult __result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | result |     |
| System.IAsyncResult | \_\_result |     |

#### Invoke(T, T, Single, out T)

##### Declaration

```
public virtual void Invoke(T item1, T item2, float interpolator, out T result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item1 |     |
| T   | item2 |     |
| System.Single | interpolator |     |
| T   | result |     |