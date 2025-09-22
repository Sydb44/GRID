| Type | Description |
| --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html)<TValue> | reference to [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) value of specified type |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetDefaultValue<T>(IMyTerminalBlock, String)

Returns default value of specified property as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName)

##### Declaration

```
public static T GetDefaultValue<T>(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| T   | property value as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | required value type of [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetMaximum<T>(IMyTerminalBlock, String)

Returns maximum value of specified property as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName)

##### Declaration

```
public static T GetMaximum<T>(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| T   | property value as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | required value type of [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetMinimum<T>(IMyTerminalBlock, String)

Returns minimum value of specified property as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName)

##### Declaration

```
public static T GetMinimum<T>(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| T   | property value as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | required value type of [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetMininum<T>(IMyTerminalBlock, String)

##### Declaration

```
public static T GetMininum<T>(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| T   | property value as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | required value type of [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### GetValue<T>(IMyTerminalBlock, String)

Returns value of specified property as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName)

##### Declaration

```
public static T GetValue<T>(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| T   | property value as [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |
