---
title: "Class MyFontDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyFontDefinition.html"
category: "Misc"
namespace: "VRage.Game.Definitions"
class: "MyFontDefinition"
---

# Class MyFontDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyFontDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyFontDefinition : MyDefinitionBase
```

### [](#constructors)Constructors

#### [](#VRage_Game_Definitions_MyFontDefinition__ctor)MyFontDefinition()

##### Declaration

```
public MyFontDefinition()
```

### [](#properties)Properties

#### [](#VRage_Game_Definitions_MyFontDefinition_ColorMask)ColorMask

Texture color multiplier.

##### Declaration

```
public Nullable<Color> ColorMask { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### [](#VRage_Game_Definitions_MyFontDefinition_CompatibilityPath)CompatibilityPath

Old resource path used by old mods.

##### Declaration

```
public string CompatibilityPath { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_Definitions_MyFontDefinition_Default)Default

True will make this definition load as DEBUG font and default fallback.

##### Declaration

```
public bool Default { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_Definitions_MyFontDefinition_IsValid)IsValid

Checks the validity of inderlying data.

##### Declaration

```
public bool IsValid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_Definitions_MyFontDefinition_Resources)Resources

##### Declaration

```
public IEnumerable<MyObjectBuilder_FontData> Resources { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Game_Definitions_MyFontDefinition_GetFont_VRage_Utils_MyStringHash_)GetFont(MyStringHash)

##### Declaration

```
public static MyFont GetFont(MyStringHash fontId)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| VRageRender.MyFont |     |

#### [](#VRage_Game_Definitions_MyFontDefinition_Init_VRage_Game_MyObjectBuilder_DefinitionBase_)Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

##### Overrides

#### [](#VRage_Game_Definitions_MyFontDefinition_MeasureStringRaw_System_String_System_String_System_Single_System_Boolean_)MeasureStringRaw(String, String, Single, Boolean)

##### Declaration

```
public static Vector2 MeasureStringRaw(string font, string text, float scale, bool useMyRenderGuiConstants = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | font |     |
| System.String | text |     |
| System.Single | scale |     |
| System.Boolean | useMyRenderGuiConstants |     |

##### Returns

#### [](#VRage_Game_Definitions_MyFontDefinition_MeasureStringRaw_System_String_System_Text_StringBuilder_System_Single_System_Boolean_)MeasureStringRaw(String, StringBuilder, Single, Boolean)

##### Declaration

```
public static Vector2 MeasureStringRaw(string font, StringBuilder text, float scale, bool useMyRenderGuiConstants = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | font |     |
| System.Text.StringBuilder | text |     |
| System.Single | scale |     |
| System.Boolean | useMyRenderGuiConstants |     |

##### Returns

#### [](#VRage_Game_Definitions_MyFontDefinition_MeasureStringRaw_VRage_Utils_MyStringHash_System_String_System_Single_System_Boolean_)MeasureStringRaw(MyStringHash, String, Single, Boolean)

##### Declaration

```
public static Vector2 MeasureStringRaw(MyStringHash font, string text, float scale, bool useMyRenderGuiConstants = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | font |     |
| System.String | text |     |
| System.Single | scale |     |
| System.Boolean | useMyRenderGuiConstants |     |

##### Returns

#### [](#VRage_Game_Definitions_MyFontDefinition_SplitIntoSameHeightStrings_System_String_System_String_)SplitIntoSameHeightStrings(String, String)

##### Declaration

```
public static List<string> SplitIntoSameHeightStrings(string font, string text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | font |     |
| System.String | text |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### [](#VRage_Game_Definitions_MyFontDefinition_SplitIntoSameHeightStrings_System_String_System_Text_StringBuilder_)SplitIntoSameHeightStrings(String, StringBuilder)

##### Declaration

```
public static List<string> SplitIntoSameHeightStrings(string font, StringBuilder text)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | font |     |
| System.Text.StringBuilder | text |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### [](#VRage_Game_Definitions_MyFontDefinition_UseLanguage_System_String_)UseLanguage(String)

Call to switch the Resources to different language variant.

##### Declaration

```
public void UseLanguage(string language)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | language | Language string identifier base on MyLanguagesEnum. |