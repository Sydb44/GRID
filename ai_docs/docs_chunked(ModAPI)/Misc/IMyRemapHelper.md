---
title: "Interface IMyRemapHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "IMyRemapHelper"
---

# Interface IMyRemapHelper | Space Engineers ModAPI

ModAPI interface giving access to changing id and names of entities

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyRemapHelper
```

### Methods

#### Clear()

Clears all the saved mappings from the remap helper and gets it ready for the next remapping operation.

##### Declaration

#### GetRemapInfo()

Key - old, value - new id Used to track if id is still existing

##### Declaration

```
Dictionary<long, long> GetRemapInfo()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Int64, System.Int64\> | Dictionary of remapping |

#### RemapEntityId(Int64)

Returns a new entity ID for the entity with the given old entity ID. The function will return the same new entityId only if the saveMapping argument is set to true.

##### Declaration

```
long RemapEntityId(long oldEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | oldEntityId | Old entity id |

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 | New entity id |

#### RemapEntityName(Int64)

Returns a new entity name for the entity with the given new entity name. The function will return the same new name only if the saveMapping argument is set to true.

##### Declaration

```
string RemapEntityName(long newEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | newEntityId | New entity id |

##### Returns

| Type | Description |
| --- | --- |
| System.String | New entity name |

#### RemapGroupId(String, Int32)

Returns a new ID for the given old ID for specific group (multiblockIDs, ...).

##### Declaration

```
int RemapGroupId(string group, int oldValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | group |     |
| System.Int32 | oldValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | New id |