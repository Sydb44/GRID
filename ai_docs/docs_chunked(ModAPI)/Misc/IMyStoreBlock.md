---
title: "Interface IMyStoreBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyStoreBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyStoreBlock"
---

# Interface IMyStoreBlock | Space Engineers ModAPI

Describes store block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyStoreBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Methods

#### CancelStoreItem(Int64)

Cancels the item (either order or offer).

##### Declaration

```
bool CancelStoreItem(long id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  | Id of the item to be canceled. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if item was canceled |

#### GetPlayerStoreItems(List<MyStoreQueryItem>)

Returns player store items.

##### Declaration

```
void GetPlayerStoreItems(List<MyStoreQueryItem> storeItems)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyStoreQueryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyStoreQueryItem.html)\> | storeItems | Returns items currently set in store. |

#### InsertOffer(MyStoreItemDataSimple, out Int64)

Creates store item offer and returns its id.

##### Declaration

```
MyStoreInsertResults InsertOffer(MyStoreItemDataSimple item, out long id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStoreItemDataSimple](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyStoreItemDataSimple.html) | item | Data defining the store item. |
| System.Int64 | id  | Id of the item in the shop. (Ex. needed to remove the item) |

##### Returns

| Type | Description |
| --- | --- |
| [MyStoreInsertResults](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyStoreInsertResults.html) | Result of the creation of the store item. |

#### InsertOrder(MyStoreItemDataSimple, out Int64)

Creates store item order and returns its id.

##### Declaration

```
MyStoreInsertResults InsertOrder(MyStoreItemDataSimple item, out long id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStoreItemDataSimple](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyStoreItemDataSimple.html) | item | Data defining the store item. |
| System.Int64 | id  | Id of the item in the shop. (Ex. needed to remove the item) |

##### Returns

| Type | Description |
| --- | --- |
| [MyStoreInsertResults](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyStoreInsertResults.html) | Result of the creation of the store item. |

### Extension Methods