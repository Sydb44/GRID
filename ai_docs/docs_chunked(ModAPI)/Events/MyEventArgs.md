---
title: "Class MyEventArgs"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyEventArgs.html"
category: "Events"
namespace: "VRage.Utils"
class: "MyEventArgs"
---

# Class MyEventArgs | Space Engineers ModAPI

##### Inheritance

System.Object

MyEventArgs

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyEventArgs : EventArgs
```

### Constructors

#### MyEventArgs()

##### Declaration

#### MyEventArgs(KeyValuePair<MyStringId, Object>)

##### Declaration

```
public MyEventArgs(KeyValuePair<MyStringId, object> arg)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.KeyValuePair<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), System.Object\> | arg |     |

#### MyEventArgs(KeyValuePair<MyStringId, Object>\[\])

##### Declaration

```
public MyEventArgs(KeyValuePair<MyStringId, object>[] args)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.KeyValuePair<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html), System.Object\>\[\] | args |     |

### Properties

#### ArgNames

##### Declaration

```
public Dictionary<MyStringId, object>.KeyCollection ArgNames { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.KeyCollection<> |     |

### Methods

#### GetArg(MyStringId)

##### Declaration

```
public object GetArg(MyStringId argName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | argName |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Object |     |

#### SetArg(MyStringId, Object)

##### Declaration

```
public void SetArg(MyStringId argName, object value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | argName |     |
| System.Object | value |     |