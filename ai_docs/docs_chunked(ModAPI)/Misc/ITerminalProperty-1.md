---
title: "Interface ITerminalProperty<TValue>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces"
class: "ITerminalProperty-1"
---

# Interface ITerminalProperty<TValue> | Space Engineers ModAPI

Terminal block property access

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface ITerminalProperty<TValue> : ITerminalProperty
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | Property type ([TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName)) |

### Methods

#### GetDefaultValue(IMyCubeBlock)

Default value of property (if value is not set, or value from block definition)

##### Declaration

```
TValue GetDefaultValue(IMyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block reference |

##### Returns

| Type | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetMaximum(IMyCubeBlock)

Maximum value of property (value from block definition)

##### Declaration

```
TValue GetMaximum(IMyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block reference |

##### Returns

| Type | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetMinimum(IMyCubeBlock)

Minimum value of property (value from block definition)

##### Declaration

```
TValue GetMinimum(IMyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block reference |

##### Returns

| Type | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetMininum(IMyCubeBlock)

Minimum value of property (value from block definition) - this function is obsolete, because it contains typo in name, use [GetMinimum(IMyCubeBlock)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_1_GetMinimum_VRage_Game_ModAPI_Ingame_IMyCubeBlock_)

##### Declaration

```
TValue GetMininum(IMyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block reference |

##### Returns

| Type | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetValue(IMyCubeBlock)

Retrieve property value

##### Declaration

```
TValue GetValue(IMyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block reference |

##### Returns

| Type | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### SetValue(IMyCubeBlock, TValue)

Set property value

##### Declaration

```
void SetValue(IMyCubeBlock block, TValue value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block reference |
| TValue | value | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

### Extension Methods