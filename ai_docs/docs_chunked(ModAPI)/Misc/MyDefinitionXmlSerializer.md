---
title: "Class MyDefinitionXmlSerializer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionXmlSerializer.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyDefinitionXmlSerializer"
---

# Class MyDefinitionXmlSerializer | Space Engineers ModAPI

Custom XmlSerializer for definitions that allows to override the definition type

##### Inheritance

System.Object

MyDefinitionXmlSerializer

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyDefinitionXmlSerializer : MyAbstractXmlSerializer<MyObjectBuilder_DefinitionBase>, IMyXmlSerializable, IXmlSerializable
```

### Constructors

#### MyDefinitionXmlSerializer()

##### Declaration

```
public MyDefinitionXmlSerializer()
```

#### MyDefinitionXmlSerializer(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
public MyDefinitionXmlSerializer(MyObjectBuilder_DefinitionBase data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | data |     |

### Fields

#### DEFINITION\_ELEMENT\_NAME

##### Declaration

```
public const string DEFINITION_ELEMENT_NAME = "Definition"
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### GetTypeAttribute(XmlReader)

##### Declaration

```
protected override string GetTypeAttribute(XmlReader reader)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Xml.XmlReader | reader |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

VRage.MyAbstractXmlSerializer<VRage.Game.MyObjectBuilder\_DefinitionBase>.GetTypeAttribute(System.Xml.XmlReader)

### Operators

#### Implicit(MyObjectBuilder\_DefinitionBase to MyDefinitionXmlSerializer)

##### Declaration

```
public static implicit operator MyDefinitionXmlSerializer(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionXmlSerializer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionXmlSerializer.html) |     |