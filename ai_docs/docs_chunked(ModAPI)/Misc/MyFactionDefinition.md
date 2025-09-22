---
title: "Class MyFactionDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFactionDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyFactionDefinition"
---

# Class MyFactionDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyFactionDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyFactionDefinition : MyDefinitionBase
```

### Constructors

#### MyFactionDefinition()

##### Declaration

```
public MyFactionDefinition()
```

### Fields

#### AcceptHumans

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AutoAcceptMember

##### Declaration

```
public bool AutoAcceptMember
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### BackgroundColor

##### Declaration

```
public Nullable<Vector3> BackgroundColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### DefaultRelation

##### Declaration

```
public MyRelationsBetweenFactions DefaultRelation
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyRelationsBetweenFactions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenFactions.html) |     |

#### DefaultRelationToPlayers

##### Declaration

```
public MyRelationsBetweenFactions DefaultRelationToPlayers
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyRelationsBetweenFactions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenFactions.html) |     |

#### DiscoveredByDefault

##### Declaration

```
public bool DiscoveredByDefault
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### EnableFriendlyFire

##### Declaration

```
public bool EnableFriendlyFire
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FactionIcon

##### Declaration

```
public MyStringId FactionIcon
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### FactionIconWorkshopId

##### Declaration

```
public Nullable<WorkshopId> FactionIconWorkshopId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[WorkshopId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.WorkshopId.html)\> |     |

#### Founder

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### IconColor

##### Declaration

```
public Nullable<Vector3> IconColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### IsDefault

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Name

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ObjectivePercentageCompleted

##### Declaration

```
public float ObjectivePercentageCompleted
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Score

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### StartingBalance

##### Declaration

```
public long StartingBalance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### StartingReputation

##### Declaration

```
public Nullable<int> StartingReputation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### StaticReputation

##### Declaration

```
public bool StaticReputation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StringType

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Tag

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Type

##### Declaration

```
public MyFactionTypes Type
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyFactionTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionTypes.html) |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides

#### Postprocess()

##### Declaration

```
public override void Postprocess()
```

##### Overrides