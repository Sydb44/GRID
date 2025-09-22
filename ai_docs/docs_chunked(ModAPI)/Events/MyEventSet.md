---
title: "Class MyEventSet"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyEventSet.html"
category: "Events"
namespace: "VRage.Utils"
class: "MyEventSet"
---

# Class MyEventSet | Space Engineers ModAPI

##### Inheritance

System.Object

MyEventSet

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class MyEventSet : Object
```

### Constructors

#### MyEventSet()

##### Declaration

### Methods

#### Add(MyStringId, Delegate)

##### Declaration

```
public void Add(MyStringId eventKey, Delegate handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | eventKey |     |
| System.Delegate | handler |     |

#### Raise(MyStringId, Object, EventArgs)

##### Declaration

```
public void Raise(MyStringId eventKey, object sender, EventArgs e)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | eventKey |     |
| System.Object | sender |     |
| System.EventArgs | e   |     |

#### Remove(MyStringId, Delegate)

##### Declaration

```
public void Remove(MyStringId eventKey, Delegate handler)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | eventKey |     |
| System.Delegate | handler |     |