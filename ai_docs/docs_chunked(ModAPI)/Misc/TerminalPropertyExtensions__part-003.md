
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
| T   |     |

#### GetValueBool(IMyTerminalBlock, String)

Returns value of specified property

##### Declaration

```
public static bool GetValueBool(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | property value as bool |

#### GetValueColor(IMyTerminalBlock, String)

Returns value of specified property

##### Declaration

```
public static Color GetValueColor(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | property value as Color |

#### GetValueFloat(IMyTerminalBlock, String)

Returns value of specified property

##### Declaration

```
public static float GetValueFloat(this IMyTerminalBlock block, string propertyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | property value as float |

#### Is<TValue>(ITerminalProperty)

Check property type

##### Declaration

```
public static bool Is<TValue>(this ITerminalProperty property)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ITerminalProperty](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html) | property | [ITerminalProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty-1.html) reference |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if type matches |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | value of type [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### SetValue<T>(IMyTerminalBlock, String, T)

Set value of property with type of [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName)

##### Declaration

```
public static void SetValue<T>(this IMyTerminalBlock block, string propertyId, T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |
| T   | value | value to set |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | [TypeName](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalProperty.html#Sandbox_ModAPI_Interfaces_ITerminalProperty_TypeName) |

#### SetValueBool(IMyTerminalBlock, String, Boolean)

Set bool value of property

##### Declaration

```
public static void SetValueBool(this IMyTerminalBlock block, string propertyId, bool value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |
| System.Boolean | value | value to set |

#### SetValueColor(IMyTerminalBlock, String, Color)

Set bool value of property

##### Declaration

```
public static void SetValueColor(this IMyTerminalBlock block, string propertyId, Color value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | value | value to set |

#### SetValueFloat(IMyTerminalBlock, String, Single)

Set float value of property

##### Declaration

```
public static void SetValueFloat(this IMyTerminalBlock block, string propertyId, float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | block reference |
| System.String | propertyId | property id (name) |
| System.Single | value | value to set |