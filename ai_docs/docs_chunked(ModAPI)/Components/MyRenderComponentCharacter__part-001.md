---
title: "Class MyRenderComponentCharacter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyRenderComponentCharacter.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyRenderComponentCharacter"
---

# Class MyRenderComponentCharacter | Space Engineers ModAPI

##### Inheritance

System.Object

MyRenderComponentCharacter

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyRenderComponentCharacter : MyRenderComponentSkinnedEntity, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyRenderComponentCharacter()

##### Declaration

```
public MyRenderComponentCharacter()
```

### Fields

#### JETPACK\_GLARE\_INTENSITY\_BASE

##### Declaration

```
public static float JETPACK_GLARE_INTENSITY_BASE
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_GLARE\_INTENSITY\_LENGTH

##### Declaration

```
public static float JETPACK_GLARE_INTENSITY_LENGTH
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_GLARE\_SIZE\_LENGTH

##### Declaration

```
public static float JETPACK_GLARE_SIZE_LENGTH
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_GLARE\_SIZE\_RADIUS

##### Declaration

```
public static float JETPACK_GLARE_SIZE_RADIUS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_LIGHT\_INTENSITY\_BASE

##### Declaration

```
public static float JETPACK_LIGHT_INTENSITY_BASE
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_LIGHT\_INTENSITY\_LENGTH

##### Declaration

```
public static float JETPACK_LIGHT_INTENSITY_LENGTH
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_LIGHT\_RANGE\_LENGTH

##### Declaration

```
public static float JETPACK_LIGHT_RANGE_LENGTH
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_LIGHT\_RANGE\_RADIUS

##### Declaration

```
public static float JETPACK_LIGHT_RANGE_RADIUS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_THRUST\_INTENSITY

##### Declaration

```
public static float JETPACK_THRUST_INTENSITY
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_THRUST\_INTENSITY\_BASE

##### Declaration

```
public static float JETPACK_THRUST_INTENSITY_BASE
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_THRUST\_LENGTH

##### Declaration

```
public static float JETPACK_THRUST_LENGTH
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_THRUST\_OFFSET

##### Declaration

```
public static float JETPACK_THRUST_OFFSET
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JETPACK\_THRUST\_THICKNESS

##### Declaration

```
public static float JETPACK_THRUST_THICKNESS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### AddRenderObjects()

##### Declaration

```
public override void AddRenderObjects()
```

##### Overrides

#### CleanLights()

##### Declaration

```
public void CleanLights()
```

#### Damage()

##### Declaration

#### Draw()

##### Declaration

```
public override void Draw()
```

##### Overrides

#### GetHUDBloodAlpha()

##### Declaration

```
public float GetHUDBloodAlpha()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetRandomFloat(Single, Single)

##### Declaration

```
public float GetRandomFloat(float minValue, float maxValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | minValue |     |
| System.Single | maxValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### InitJetpackThrusts(MyCharacterDefinition)

##### Declaration

```
public void InitJetpackThrusts(MyCharacterDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCharacterDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCharacterDefinition.html) | definition |     |

#### InitLight(MyCharacterDefinition)

##### Declaration

```
public void InitLight(MyCharacterDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCharacterDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCharacterDefinition.html) | definition |     |

#### InvalidateRenderObjects()

##### Declaration

```
public override void InvalidateRenderObjects()
```

##### Overrides

#### RemoveRenderObjects()

##### Declaration

```
public override void RemoveRenderObjects()
```

##### Overrides

#### UpdateLight(Single, Boolean, Boolean)

##### Declaration

```
public void UpdateLight(float lightPower, bool updateRenderObject, bool updateBasicLight)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | lightPower |     |
| System.Boolean | updateRenderObject |     |
| System.Boolean | updateBasicLight |     |

#### UpdateLightPosition()

##### Declaration

```
public void UpdateLightPosition()
```

#### UpdateLightProperties(Single)

##### Declaration

```
public void UpdateLightProperties(float currentLightPower)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | currentLightPower |     |

#### UpdateShadowIgnoredObjects()

##### Declaration

```
public void UpdateShadowIgnoredObjects()
```

#### UpdateShadowIgnoredObjects(IMyEntity)

##### Declaration

```
public void UpdateShadowIgnoredObjects(IMyEntity Parent)
```
