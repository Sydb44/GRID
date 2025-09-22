---
title: "Class MyPathRecorderComponentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyPathRecorderComponentDefinition.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyPathRecorderComponentDefinition"
---

# Class MyPathRecorderComponentDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyPathRecorderComponentDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyPathRecorderComponentDefinition : MyComponentDefinitionBase
```

### Constructors

#### MyPathRecorderComponentDefinition()

##### Declaration

```
public MyPathRecorderComponentDefinition()
```

### Fields

#### MaxDistanceBetweenRecords

##### Declaration

```
public float MaxDistanceBetweenRecords
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxRecordTime

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxUpdateBetweenRecords

##### Declaration

```
public byte MaxUpdateBetweenRecords
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### MaxWaypoints

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MinDistanceBetweenRecords

##### Declaration

```
public float MinDistanceBetweenRecords
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinUpdateBetweenRecords

##### Declaration

```
public byte MinUpdateBetweenRecords
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### RecordInterval

##### Declaration

```
public byte RecordInterval
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

### Methods

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

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