---
title: "Class MyModifiableEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyModifiableEntity.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyModifiableEntity"
---

# Class MyModifiableEntity | Space Engineers ModAPI

##### Inheritance

System.Object

MyModifiableEntity

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyModifiableEntity : MyEntity, IMyEntity, IMyEntity, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyModifiableEntity()

##### Declaration

```
public MyModifiableEntity()
```

### Methods

#### AddAssetModifier(MyDefinitionId)

##### Declaration

```
public void AddAssetModifier(MyDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |

#### GetAssetModifiers()

##### Declaration

```
public List<MyDefinitionId> GetAssetModifiers()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

#### RemoveAssetModifier(MyDefinitionId)

##### Declaration

```
public void RemoveAssetModifier(MyDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Implements

### Extension Methods