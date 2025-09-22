---
title: "Class MyObjectBuilder\\_Toolbar"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Toolbar"
---

# Class MyObjectBuilder\_Toolbar | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Toolbar

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Toolbar : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_Toolbar()

##### Declaration

```
public MyObjectBuilder_Toolbar()
```

### Fields

#### ColorMaskHSVList

##### Declaration

```
[NoSerialize]
public List<Vector3> ColorMaskHSVList
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### SelectedSlot

##### Declaration

```
[Serialize]
public Nullable<int> SelectedSlot
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### Slots

##### Declaration

```
[Serialize]
public List<MyObjectBuilder_Toolbar.Slot> Slots
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_Toolbar.Slot](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.Slot.html)\> |     |

#### SlotsGamepad

##### Declaration

```
[Serialize]
public List<MyObjectBuilder_Toolbar.Slot> SlotsGamepad
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_Toolbar.Slot](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.Slot.html)\> |     |

#### ToolbarType

##### Declaration

```
public MyToolbarType ToolbarType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyToolbarType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyToolbarType.html) |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

#### ShouldSerializeColorMaskHSVList()

##### Declaration

```
public bool ShouldSerializeColorMaskHSVList()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods