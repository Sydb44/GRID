---
title: "Class MyObjectBuilder\\_EntityBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html"
category: "Misc"
namespace: "VRage.ObjectBuilders"
class: "MyObjectBuilder_EntityBase"
---

# Class MyObjectBuilder\_EntityBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_EntityBase

##### Inherited Members

###### **Namespace**: [VRage.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_EntityBase : MyObjectBuilder_Base
```

### [](#constructors)Constructors

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase__ctor)MyObjectBuilder\_EntityBase()

##### Declaration

```
public MyObjectBuilder_EntityBase()
```

### [](#fields)Fields

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_ComponentContainer)ComponentContainer

##### Declaration

```
[Serialize]
public MyObjectBuilder_ComponentContainer ComponentContainer
```

##### Field Value

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_EntityDefinitionId)EntityDefinitionId

##### Declaration

```
[NoSerialize]
public Nullable<SerializableDefinitionId> EntityDefinitionId
```

##### Field Value

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_EntityId)EntityId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_LocalPositionAndOrientation)LocalPositionAndOrientation

##### Declaration

```
public Nullable<MyPositionAndOrientation> LocalPositionAndOrientation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyPositionAndOrientation\> |     |

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_Name)Name

##### Declaration

```
[Serialize]
public string Name
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_PersistentFlags)PersistentFlags

##### Declaration

```
public MyPersistentEntityFlags2 PersistentFlags
```

##### Field Value

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_PositionAndOrientation)PositionAndOrientation

##### Declaration

```
public Nullable<MyPositionAndOrientation> PositionAndOrientation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyPositionAndOrientation\> |     |

### [](#methods)Methods

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_Remap_VRage_ModAPI_IMyRemapHelper_)Remap(IMyRemapHelper)

Remaps this entity's entityId to a new value. If there are cross-referenced between different entities in this object builder, the remapHelper should be used to rememeber these references and retrieve them.

##### Declaration

```
public virtual void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_ShouldSerializeComponentContainer)ShouldSerializeComponentContainer()

##### Declaration

```
public bool ShouldSerializeComponentContainer()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_ShouldSerializeEntityDefinitionId)ShouldSerializeEntityDefinitionId()

##### Declaration

```
public bool ShouldSerializeEntityDefinitionId()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_ShouldSerializeLocalPositionAndOrientation)ShouldSerializeLocalPositionAndOrientation()

##### Declaration

```
public bool ShouldSerializeLocalPositionAndOrientation()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_ObjectBuilders_MyObjectBuilder_EntityBase_ShouldSerializePositionAndOrientation)ShouldSerializePositionAndOrientation()

##### Declaration

```
public bool ShouldSerializePositionAndOrientation()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#extensionmethods)Extension Methods