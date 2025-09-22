---
title: "Class MyRandom"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.MyRandom.html"
category: "Misc"
namespace: "VRage.Library.Utils"
class: "MyRandom"
---

# Class MyRandom | Space Engineers ModAPI

Original C# implementation which allows settings the seed.

##### Inheritance

System.Object

MyRandom

###### **Namespace**: [VRage.Library.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Library.Utils.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyRandom : Object
```

### [](#constructors)Constructors

#### [](#VRage_Library_Utils_MyRandom__ctor)MyRandom()

##### Declaration

#### [](#VRage_Library_Utils_MyRandom__ctor_System_Int32_)MyRandom(Int32)

##### Declaration

```
public MyRandom(int Seed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | Seed |     |

### [](#properties)Properties

#### [](#VRage_Library_Utils_MyRandom_Instance)Instance

##### Declaration

```
public static MyRandom Instance { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Library_Utils_MyRandom_CreateRandomSeed)CreateRandomSeed()

##### Declaration

```
public int CreateRandomSeed()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Library_Utils_MyRandom_GetRandomFloat_System_Single_System_Single_)GetRandomFloat(Single, Single)

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

#### [](#VRage_Library_Utils_MyRandom_GetRandomSign)GetRandomSign()

##### Declaration

```
public float GetRandomSign()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Library_Utils_MyRandom_GetState_VRage_Library_Utils_MyRandom_State__)GetState(out MyRandom.State)

##### Declaration

```
public void GetState(out MyRandom.State state)
```

##### Parameters

#### [](#VRage_Library_Utils_MyRandom_Next)Next()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Library_Utils_MyRandom_Next_System_Int32_)Next(Int32)

##### Declaration

```
public int Next(int maxValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | maxValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Library_Utils_MyRandom_Next_System_Int32_System_Int32_)Next(Int32, Int32)

##### Declaration

```
public int Next(int minValue, int maxValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | minValue |     |
| System.Int32 | maxValue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Library_Utils_MyRandom_NextBytes_System_Byte___)NextBytes(Byte\[\])

##### Declaration

```
public void NextBytes(byte[] buffer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | buffer |     |

#### [](#VRage_Library_Utils_MyRandom_NextDouble)NextDouble()

##### Declaration

```
public double NextDouble()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRage_Library_Utils_MyRandom_NextFloat)NextFloat()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Library_Utils_MyRandom_NextLong)NextLong()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#VRage_Library_Utils_MyRandom_PushSeed_System_Int32_)PushSeed(Int32)

##### Declaration

```
public MyRandom.StateToken PushSeed(int newSeed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | newSeed |     |

##### Returns

#### [](#VRage_Library_Utils_MyRandom_Sample)Sample()

##### Declaration

```
protected double Sample()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRage_Library_Utils_MyRandom_SetSeed_System_Int32_)SetSeed(Int32)

Sets new seed, only use this method when you have separate instance of MyRandom. Setting seed for RNG used for EntityId without reverting to previous state is dangerous. Use PushSeed for EntityId random generator.

##### Declaration

```
public void SetSeed(int Seed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | Seed |     |

#### [](#VRage_Library_Utils_MyRandom_SetState_VRage_Library_Utils_MyRandom_State__)SetState(ref MyRandom.State)

##### Declaration

```
public void SetState(ref MyRandom.State state)
```

##### Parameters