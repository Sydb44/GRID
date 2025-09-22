---
title: "Class MyAssetModifierComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAssetModifierComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyAssetModifierComponent"
---

# Class MyAssetModifierComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyAssetModifierComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
[MyComponentBuilder]
public class MyAssetModifierComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyAssetModifierComponent()

##### Declaration

```
public MyAssetModifierComponent()
```

### Properties

#### AssetModifiers

##### Declaration

```
public List<MyDefinitionId> AssetModifiers { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

### Methods

#### ApplyAssetModifierSync(Int64, Byte\[\], Boolean)

##### Declaration

```
[Event(null, 258)]
[Reliable]
[Server]
[Broadcast]
public static void ApplyAssetModifierSync(long entityId, byte[] checkData, bool addToList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Byte\[\] | checkData |     |
| System.Boolean | addToList |     |

#### ApplyAssetModifierSync(Int64, String, Boolean)

##### Declaration

```
[Event(null, 293)]
[Reliable]
[Server]
[Broadcast]
public static void ApplyAssetModifierSync(long entityId, string assetModifierId, bool addToList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.String | assetModifierId |     |
| System.Boolean | addToList |     |

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### LazyUpdate()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnRemovedFromScene()

##### Declaration

```
public override void OnRemovedFromScene()
```

##### Overrides

#### ResetDrill(MyEntity)

##### Declaration

```
public static void ResetDrill(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### ResetGrinder(MyEntity)

##### Declaration

```
public static void ResetGrinder(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### ResetRifle(MyEntity)

##### Declaration

```
public static void ResetRifle(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### ResetSlot(MyGameInventoryItemSlot)

##### Declaration

```
public void ResetSlot(MyGameInventoryItemSlot slot)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.GameServices.MyGameInventoryItemSlot | slot |     |

#### ResetWelder(MyEntity)

##### Declaration

```
public static void ResetWelder(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### SetDefaultTextures(MyEntity, String)

##### Declaration

```
public static void SetDefaultTextures(MyEntity entity, string materialName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.String | materialName |     |

#### TryAddAssetModifier(Byte\[\])

##### Declaration

```
public bool TryAddAssetModifier(byte[] checkData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | checkData |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryAddAssetModifier(String)

##### Declaration

```
public bool TryAddAssetModifier(string assetModifierId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | assetModifierId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
