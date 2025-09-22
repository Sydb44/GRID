    *   [Vector3L](VRageMath.Vector3L.html "Vector3L")
    *   [Vector3L.EqualityComparer](VRageMath.Vector3L.EqualityComparer.html "Vector3L.EqualityComparer")
    *   [Vector3L\_RangeIterator](VRageMath.Vector3L_RangeIterator.html "Vector3L_RangeIterator")
    *   [Vector3LNormalEqualityComparer](VRageMath.Vector3LNormalEqualityComparer.html "Vector3LNormalEqualityComparer")
    *   [Vector3S](VRageMath.Vector3S.html "Vector3S")
    *   [Vector3UByte](VRageMath.Vector3UByte.html "Vector3UByte")
    *   [Vector3UByte.EqualityComparer](VRageMath.Vector3UByte.EqualityComparer.html "Vector3UByte.EqualityComparer")
    *   [Vector3Ushort](VRageMath.Vector3Ushort.html "Vector3Ushort")
    *   [Vector4](VRageMath.Vector4.html "Vector4")
    *   [Vector4D](VRageMath.Vector4D.html "Vector4D")
    *   [Vector4I](VRageMath.Vector4I.html "Vector4I")
    *   [Vector4I.EqualityComparer](VRageMath.Vector4I.EqualityComparer.html "Vector4I.EqualityComparer")
    *   [Vector4UByte](VRageMath.Vector4UByte.html "Vector4UByte")

# Class MyModStorageComponentDefinition

##### Inheritance

System.Object

[MyDefinitionBase](VRage.Game.MyDefinitionBase.html)

[MyComponentDefinitionBase](VRage.Game.MyComponentDefinitionBase.html)

MyModStorageComponentDefinition

##### Inherited Members

[MyComponentDefinitionBase.ToString()](VRage.Game.MyComponentDefinitionBase.html#VRage_Game_MyComponentDefinitionBase_ToString)

[MyDefinitionBase.Id](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Id)

[MyDefinitionBase.DisplayNameEnum](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DisplayNameEnum)

[MyDefinitionBase.DescriptionEnum](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionEnum)

[MyDefinitionBase.DisplayNameString](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DisplayNameString)

[MyDefinitionBase.DescriptionString](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionString)

[MyDefinitionBase.DescriptionArgs](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionArgs)

[MyDefinitionBase.Icons](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Icons)

[MyDefinitionBase.Enabled](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Enabled)

[MyDefinitionBase.Public](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Public)

[MyDefinitionBase.AvailableInSurvival](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_AvailableInSurvival)

[MyDefinitionBase.Context](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Context)

[MyDefinitionBase.Init(MyObjectBuilder\_DefinitionBase, MyModContext)](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Init_VRage_Game_MyObjectBuilder_DefinitionBase_VRage_Game_MyModContext_)

[MyDefinitionBase.Postprocess()](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_Postprocess)

[MyDefinitionBase.CheckDefinitionDLCs(String\[\])](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_CheckDefinitionDLCs_System_String___)

[MyDefinitionBase.DLCs](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DLCs)

[MyDefinitionBase.DisplayNameText](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DisplayNameText)

[MyDefinitionBase.DescriptionText](VRage.Game.MyDefinitionBase.html#VRage_Game_MyDefinitionBase_DescriptionText)

###### **Namespace**: [VRage.Game.Definitions](VRage.Game.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyModStorageComponentDefinition : MyComponentDefinitionBase
```

### [](#constructors)Constructors

#### [](#VRage_Game_Definitions_MyModStorageComponentDefinition__ctor)MyModStorageComponentDefinition()

##### Declaration

```
public MyModStorageComponentDefinition()
```

### [](#fields)Fields

#### [](#VRage_Game_Definitions_MyModStorageComponentDefinition_RegisteredStorageGuids)RegisteredStorageGuids

##### Declaration

```
public Guid[] RegisteredStorageGuids
```

##### Field Value

Type

Description

System.Guid\[\]

### [](#methods)Methods

#### [](#VRage_Game_Definitions_MyModStorageComponentDefinition_GetObjectBuilder)GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

Type

Description

[MyObjectBuilder\_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase.html)

##### Overrides

[MyComponentDefinitionBase.GetObjectBuilder()](VRage.Game.MyComponentDefinitionBase.html#VRage_Game_MyComponentDefinitionBase_GetObjectBuilder)

#### [](#VRage_Game_Definitions_MyModStorageComponentDefinition_Init_VRage_Game_MyObjectBuilder_DefinitionBase_)Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_DefinitionBase](VRage.Game.MyObjectBuilder_DefinitionBase.html)

builder

##### Overrides

[MyComponentDefinitionBase.Init(MyObjectBuilder\_DefinitionBase)](VRage.Game.MyComponentDefinitionBase.html#VRage_Game_MyComponentDefinitionBase_Init_VRage_Game_MyObjectBuilder_DefinitionBase_)

_☀_

_☾_