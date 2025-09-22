---
title: "Class MyObjectBuilder\\_FactionCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FactionCollection.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_FactionCollection"
---

# Class MyObjectBuilder\_FactionCollection | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_FactionCollection

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_FactionCollection : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_FactionCollection()

##### Declaration

```
public MyObjectBuilder_FactionCollection()
```

### Fields

#### Factions

##### Declaration

```
public List<MyObjectBuilder_Faction> Factions
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_Faction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Faction.html)\> |     |

#### Players

##### Declaration

```
public SerializableDictionary<long, long> Players
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Serialization.SerializableDictionary<System.Int64, System.Int64\> |     |

#### PlayerToFactionsVis

##### Declaration

```
public List<MyObjectBuilder_FactionsVisEntry> PlayerToFactionsVis
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_FactionsVisEntry](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FactionsVisEntry.html)\> |     |

#### Relations

##### Declaration

```
public List<MyObjectBuilder_FactionRelation> Relations
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_FactionRelation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FactionRelation.html)\> |     |

#### RelationsWithPlayers

##### Declaration

```
public List<MyObjectBuilder_PlayerFactionRelation> RelationsWithPlayers
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_PlayerFactionRelation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PlayerFactionRelation.html)\> |     |

#### Requests

##### Declaration

```
public List<MyObjectBuilder_FactionRequests> Requests
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_FactionRequests](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FactionRequests.html)\> |     |

### Extension Methods