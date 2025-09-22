---
title: "Class MyForageableEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyForageableEntity.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyForageableEntity"
---

# Class MyForageableEntity | Space Engineers ModAPI

##### Inheritance

System.Object

MyForageableEntity

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyForageableEntity : MyEntity, IMyEntity, IMyEntity, IMyEventProxy, IMyEventOwner
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyForageableEntity__ctor)MyForageableEntity()

##### Declaration

```
public MyForageableEntity()
```

#### [](#Sandbox_Game_Entities_MyForageableEntity__ctor_Sandbox_Game_WorldEnvironment_MyEnvironmentSector_System_Int32_Sandbox_Definitions_MyForageableDefinition_)MyForageableEntity(MyEnvironmentSector, Int32, MyForageableDefinition)

##### Declaration

```
public MyForageableEntity(MyEnvironmentSector sector, int itemId, MyForageableDefinition definition)
```

##### Parameters

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyForageableEntity_Definition)Definition

##### Declaration

```
public MyForageableDefinition Definition { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyForageableEntity_EnvironmentSector)EnvironmentSector

##### Declaration

```
public MyEnvironmentSector EnvironmentSector { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyForageableEntity_ItemId)ItemId

##### Declaration

```
public int ItemId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#Sandbox_Game_Entities_MyForageableEntity_PlanetId)PlanetId

##### Declaration

```
public long PlanetId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#Sandbox_Game_Entities_MyForageableEntity_SectorId)SectorId

##### Declaration

```
public long SectorId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#Sandbox_Game_Entities_MyForageableEntity_WasForaged)WasForaged

##### Declaration

```
public bool WasForaged { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyForageableEntity_Forage_System_Nullable_System_Int64__)Forage(Nullable<Int64>)

##### Declaration

```
public void Forage(Nullable<long> collectorId = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | collectorId |     |

#### [](#Sandbox_Game_Entities_MyForageableEntity_GetObjectBuilder_System_Boolean_)GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyForageableEntity_Init_VRage_ObjectBuilders_MyObjectBuilder_EntityBase_)Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

##### Overrides

### [](#implements)Implements

### [](#extensionmethods)Extension Methods