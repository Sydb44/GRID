---
title: "Interface IMyScriptBlacklistBatch"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyScriptBlacklistBatch.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyScriptBlacklistBatch"
---

# Interface IMyScriptBlacklistBatch | Space Engineers ModAPI

A handle which enables adding members to the blacklist in a batch. It is highly recommended that you try to group your changes into as few batches as possible.

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyScriptBlacklistBatch : IDisposable
```

### Methods

#### AddMembers(Type, String\[\])

Adds only the specified members to the blacklist.

##### Declaration

```
void AddMembers(Type type, params string[] memberNames)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |
| System.String\[\] | memberNames |     |

#### AddNamespaceOfTypes(Type\[\])

Adds the entire namespace of one or more given types to the blacklist

##### Declaration

```
void AddNamespaceOfTypes(params Type[] types)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type\[\] | types |     |

#### AddTypes(Type\[\])

Adds one or more specific types and all their members to the blacklist.

##### Declaration

```
void AddTypes(params Type[] types)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type\[\] | types |     |

#### RemoveMembers(Type, String\[\])

##### Declaration

```
void RemoveMembers(Type type, params string[] memberNames)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |
| System.String\[\] | memberNames |     |

#### RemoveNamespaceOfTypes(Type\[\])

##### Declaration

```
void RemoveNamespaceOfTypes(params Type[] types)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type\[\] | types |     |

#### RemoveTypes(Type\[\])

Removes types previously added with [AddTypes(Type\[\])](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyScriptBlacklistBatch.html#Sandbox_ModAPI_IMyScriptBlacklistBatch_AddTypes_System_Type___) from the blacklist.

##### Declaration

```
void RemoveTypes(params Type[] types)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type\[\] | types |     |