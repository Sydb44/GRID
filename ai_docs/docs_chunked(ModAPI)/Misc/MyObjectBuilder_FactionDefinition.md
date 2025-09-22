---
title: "Class MyObjectBuilder\\_FactionDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_FactionDefinition.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders.Definitions"
class: "MyObjectBuilder_FactionDefinition"
---

# Class MyObjectBuilder\_FactionDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_FactionDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_FactionDefinition : MyObjectBuilder_DefinitionBase
```

### Constructors

#### MyObjectBuilder\_FactionDefinition()

##### Declaration

```
public MyObjectBuilder_FactionDefinition()
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
[Serialize]
public Nullable<ColorDefinitionRGBA> BackgroundColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html)\> |     |

#### DefaultRelation

Default faction relation to the other factions. Enemies state is with highest prority and does not care if other faction want to be friend.

##### Declaration

```
public MyRelationsBetweenFactions DefaultRelation
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

Path to banner icon.

##### Declaration

```
[ModdableContentFile(new string[]{"dds", "png"})]
public string FactionIcon
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

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
[Serialize]
public Nullable<ColorDefinitionRGBA> IconColor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html)\> |     |

#### IsDefault

This value indicates if fraction should be created by default for every new world and its owner will be visible in Ownership dropdown.

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

#### StartingBalance

Starting balance of the faction.

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
[Serialize]
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

### Extension Methods