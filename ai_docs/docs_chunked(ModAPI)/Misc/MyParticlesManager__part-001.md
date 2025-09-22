---
title: "Class MyParticlesManager"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyParticlesManager.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyParticlesManager"
---

# Class MyParticlesManager | Space Engineers ModAPI

##### Inheritance

System.Object

MyParticlesManager

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MySessionComponentDescriptor]
public class MyParticlesManager : MySessionComponentBase, IMyUserInputComponent, IParticleManager
```

### [](#constructors)Constructors

#### [](#VRage_Game_MyParticlesManager__ctor)MyParticlesManager()

##### Declaration

```
public MyParticlesManager()
```

### [](#fields)Fields

#### [](#VRage_Game_MyParticlesManager_CalculateGravityInPoint)CalculateGravityInPoint

##### Declaration

```
public static Func<Vector3D, Vector3> CalculateGravityInPoint
```

##### Field Value

#### [](#VRage_Game_MyParticlesManager_Enabled)Enabled

##### Declaration

```
public static bool Enabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#properties)Properties

#### [](#VRage_Game_MyParticlesManager_CurrentTime)CurrentTime

##### Declaration

```
public static MyTimeSpan CurrentTime { get; }
```

##### Property Value

#### [](#VRage_Game_MyParticlesManager_Effects)Effects

##### Declaration

```
public static IEnumerable<MyParticleEffect> Effects { get; }
```

##### Property Value

#### [](#VRage_Game_MyParticlesManager_InstanceCount)InstanceCount

##### Declaration

```
public static int InstanceCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_MyParticlesManager_Paused)Paused

##### Declaration

```
public static bool Paused { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#VRage_Game_MyParticlesManager_LoadData)LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### [](#VRage_Game_MyParticlesManager_OnRemoved_System_UInt32_)OnRemoved(UInt32)

##### Declaration

```
public static void OnRemoved(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

#### [](#VRage_Game_MyParticlesManager_RecreateParticleEffects_VRage_Render_Particles_MyParticleEffectData_)RecreateParticleEffects(MyParticleEffectData)

##### Declaration

```
public void RecreateParticleEffects(MyParticleEffectData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Render.Particles.MyParticleEffectData | data |     |

#### [](#VRage_Game_MyParticlesManager_RemoveParticleEffect_VRage_Game_MyParticleEffect_)RemoveParticleEffect(MyParticleEffect)

##### Declaration

```
public static void RemoveParticleEffect(MyParticleEffect effect)
```

##### Parameters

#### [](#VRage_Game_MyParticlesManager_RemoveParticleEffects_VRage_Render_Particles_MyParticleEffectData_)RemoveParticleEffects(MyParticleEffectData)

##### Declaration

```
public void RemoveParticleEffects(MyParticleEffectData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Render.Particles.MyParticleEffectData | data |     |

#### [](#VRage_Game_MyParticlesManager_ScheduleUpdate_VRage_Game_MyParticleEffect_)ScheduleUpdate(MyParticleEffect)

##### Declaration

```
public static void ScheduleUpdate(MyParticleEffect effect)
```

##### Parameters

#### [](#VRage_Game_MyParticlesManager_TryCreateParticleEffect_System_Int32_VRage_Game_MyParticleEffect__System_Boolean_)TryCreateParticleEffect(Int32, out MyParticleEffect, Boolean)

##### Declaration

```
public static bool TryCreateParticleEffect(int id, out MyParticleEffect effect, bool userDraw = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |
| [MyParticleEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyParticleEffect.html) | effect |     |
| System.Boolean | userDraw |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyParticlesManager_TryCreateParticleEffect_System_Int32_VRage_Game_MyParticleEffect__VRageMath_MatrixD__VRageMath_Vector3D__System_UInt32_System_Boolean_)TryCreateParticleEffect(Int32, out MyParticleEffect, ref MatrixD, ref Vector3D, UInt32, Boolean)

##### Declaration

```
public static bool TryCreateParticleEffect(int id, out MyParticleEffect effect, ref MatrixD effectMatrix, ref Vector3D worldPosition, uint parentID, bool userDraw = false)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyParticlesManager_TryCreateParticleEffect_System_String_VRage_Game_MyParticleEffect__)TryCreateParticleEffect(String, out MyParticleEffect)

##### Declaration

```
public static bool TryCreateParticleEffect(string effectName, out MyParticleEffect effect)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyParticlesManager_TryCreateParticleEffect_System_String_VRageMath_MatrixD_VRage_Game_MyParticleEffect__)TryCreateParticleEffect(String, MatrixD, out MyParticleEffect)

##### Declaration

```
public static bool TryCreateParticleEffect(string effectName, MatrixD worldMatrix, out MyParticleEffect effect)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_MyParticlesManager_TryCreateParticleEffect_System_String_VRageMath_MatrixD__VRageMath_Vector3D__System_UInt32_VRage_Game_MyParticleEffect__)TryCreateParticleEffect(String, ref MatrixD, ref Vector3D, UInt32, out MyParticleEffect)

##### Declaration

```
public static bool TryCreateParticleEffect(string effectName, ref MatrixD effectMatrix, ref Vector3D worldPosition, uint parentID, out MyParticleEffect effect)
```
