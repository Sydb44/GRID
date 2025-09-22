---
title: "Class MyObjectBuilder\\_Ore"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Ore.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_Ore"
---

# Class MyObjectBuilder\_Ore | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_Ore

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_Ore : MyObjectBuilder_PhysicalObject
```

### Constructors

#### MyObjectBuilder\_Ore()

##### Declaration

```
public MyObjectBuilder_Ore()
```

### Fields

#### MaterialTypeName

##### Declaration

```
[Nullable]
public Nullable<MyStringHash> MaterialTypeName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> |     |

### Properties

#### MaterialNameString

##### Declaration

```
[NoSerialize]
public string MaterialNameString { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### Clone()

##### Declaration

```
public override MyObjectBuilder_Base Clone()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) |     |

##### Overrides

#### GetMaterialName()

##### Declaration

```
public string GetMaterialName()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### HasMaterialName()

##### Declaration

```
public bool HasMaterialName()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods