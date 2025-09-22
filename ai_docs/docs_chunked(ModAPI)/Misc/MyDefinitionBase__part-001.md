---
title: "Class MyDefinitionBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyDefinitionBase"
---

# Class MyDefinitionBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyDefinitionBase

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyDefinitionBase : Object
```

### Constructors

#### MyDefinitionBase()

##### Declaration

```
public MyDefinitionBase()
```

### Fields

#### AvailableInSurvival

##### Declaration

```
public bool AvailableInSurvival
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Context

##### Declaration

```
public MyModContext Context
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) |     |

#### DescriptionArgs

String used for shortcuts used in description

##### Declaration

```
public string DescriptionArgs
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DescriptionEnum

Enum used for localization of description. Null for player created definitions.

##### Declaration

```
public Nullable<MyStringId> DescriptionEnum
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> |     |

#### DescriptionString

String used for user created description which do not have localization support.

##### Declaration

```
public string DescriptionString
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DisplayNameEnum

Enum used for localization of display name. Null for player created definitions.

##### Declaration

```
public Nullable<MyStringId> DisplayNameEnum
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> |     |

#### DisplayNameString

String name used for user created definitions which do not have localization support.

##### Declaration

```
public string DisplayNameString
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Enabled

Definition can be disabled by mod, then it will be removed from definition manager

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Icons

Icons for the definition, they are used from top to bottom.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String\[\] |     |

#### Id

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### Public

Indicates if definition should be offered in Cube builder

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### DescriptionText

Use this property when showing description in GUI, as it takes into account more complex description construction.

##### Declaration

```
public virtual string DescriptionText { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DisplayNameText

Use this property when showing name in GUI instead of DisplayName. This takes into account more complex name construction.

##### Declaration

```
public virtual string DisplayNameText { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DLCs

##### Declaration

```
public string[] DLCs { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String\[\] |     |

### Methods

#### CheckDefinitionDLCs(String\[\])

Checks if the definition has all required DLCs as it should have

##### Declaration

```
public void CheckDefinitionDLCs(string[] dlcNames)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String\[\] | dlcNames | required DLCs |

#### GetObjectBuilder()

##### Declaration

```
public virtual MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected virtual void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

#### Init(MyObjectBuilder\_DefinitionBase, MyModContext)

##### Declaration

```
public void Init(MyObjectBuilder_DefinitionBase builder, MyModContext modContext)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |
| [MyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyModContext.html) | modContext |     |

#### Postprocess()

Override this in case you want to do some postprocessing of the definition before the game starts. Prefer to use MyDefinitionPostprocessor instead.

Postprocess is useful if you want to process the definition before the game begins,

but you only want to do it when all the definitions are loaded and merged.

##### Declaration

```
public virtual void Postprocess()
```

#### ToString()

##### Declaration

```
public override string ToString()
```
