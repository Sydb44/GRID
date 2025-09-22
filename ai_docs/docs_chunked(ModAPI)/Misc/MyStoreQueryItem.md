---
title: "Class MyStoreQueryItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyStoreQueryItem.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyStoreQueryItem"
---

# Class MyStoreQueryItem | Space Engineers ModAPI

Describes store query item

##### Inheritance

System.Object

MyStoreQueryItem

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyStoreQueryItem : ValueType
```

### Fields

#### Amount

Gets amount for buy/sell

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Id

Id of the store item. Ex. Needed for removing item from store.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ItemId

Gets definition id of the item

##### Declaration

```
public SerializableDefinitionId ItemId
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) |     |

#### PricePerUnit

Gets price per unit

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |