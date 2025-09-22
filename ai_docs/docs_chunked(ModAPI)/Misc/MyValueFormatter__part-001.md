---
title: "Class MyValueFormatter"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyValueFormatter.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyValueFormatter"
---

# Class MyValueFormatter | Space Engineers ModAPI

##### Inheritance

System.Object

MyValueFormatter

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class MyValueFormatter : Object
```

### Constructors

#### MyValueFormatter()

##### Declaration

```
public MyValueFormatter()
```

### Methods

#### AppendDistanceInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendDistanceInBestUnit(float distanceInMeters, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | distanceInMeters |     |
| System.Text.StringBuilder | output |     |

#### AppendForceInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendForceInBestUnit(float forceInNewtons, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | forceInNewtons |     |
| System.Text.StringBuilder | output |     |

#### AppendFormattedValueInBestUnit(Single, String\[\], Single\[\], Int32, StringBuilder)

##### Declaration

```
public static void AppendFormattedValueInBestUnit(float value, string[] unitNames, float[] unitMultipliers, int unitDecimalDigits, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |
| System.String\[\] | unitNames |     |
| System.Single\[\] | unitMultipliers |     |
| System.Int32 | unitDecimalDigits |     |
| System.Text.StringBuilder | output |     |

#### AppendFormattedValueInBestUnit(Single, String\[\], Single\[\], Int32\[\], StringBuilder)

##### Declaration

```
public static void AppendFormattedValueInBestUnit(float value, string[] unitNames, float[] unitMultipliers, int[] unitDecimalDigits, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value |     |
| System.String\[\] | unitNames |     |
| System.Single\[\] | unitMultipliers |     |
| System.Int32\[\] | unitDecimalDigits |     |
| System.Text.StringBuilder | output |     |

#### AppendGenericInBestUnit(Single, Int32, StringBuilder)

##### Declaration

```
public static void AppendGenericInBestUnit(float genericInBase, int numDecimals, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | genericInBase |     |
| System.Int32 | numDecimals |     |
| System.Text.StringBuilder | output |     |

#### AppendGenericInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendGenericInBestUnit(float genericInBase, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | genericInBase |     |
| System.Text.StringBuilder | output |     |

#### AppendTimeExact(Int32, StringBuilder)

##### Declaration

```
public static void AppendTimeExact(int timeInSeconds, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | timeInSeconds |     |
| System.Text.StringBuilder | output |     |

#### AppendTimeExactHoursMinSec(Int32, StringBuilder)

##### Declaration

```
public static void AppendTimeExactHoursMinSec(int timeInSeconds, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | timeInSeconds |     |
| System.Text.StringBuilder | output |     |

#### AppendTimeExactMinSec(Int32, StringBuilder)

##### Declaration

```
public static void AppendTimeExactMinSec(int timeInSeconds, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | timeInSeconds |     |
| System.Text.StringBuilder | output |     |

#### AppendTimeInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendTimeInBestUnit(float timeInSeconds, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | timeInSeconds |     |
| System.Text.StringBuilder | output |     |

#### AppendTorqueInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendTorqueInBestUnit(float torqueInNewtonMeters, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | torqueInNewtonMeters |     |
| System.Text.StringBuilder | output |     |

#### AppendVolumeInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendVolumeInBestUnit(float volumeInCubicMeters, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | volumeInCubicMeters |     |
| System.Text.StringBuilder | output |     |

#### AppendWeightInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendWeightInBestUnit(float weightInKG, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | weightInKG |     |
| System.Text.StringBuilder | output |     |

#### AppendWorkHoursInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendWorkHoursInBestUnit(float workInMegaWatts, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | workInMegaWatts |     |
| System.Text.StringBuilder | output |     |

#### AppendWorkInBestUnit(Single, StringBuilder)

##### Declaration

```
public static void AppendWorkInBestUnit(float workInMegaWatts, StringBuilder output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | workInMegaWatts |     |
| System.Text.StringBuilder | output |     |

#### GetDecimalFromString(String, Int32)
