---
title: "Class MyAutorotateMode"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyAutorotateMode.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyAutorotateMode"
---

# Class MyAutorotateMode | Space Engineers ModAPI

##### Inheritance

System.Object

MyAutorotateMode

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyAutorotateMode : Enum
```

### [](#fields)Fields

#### [](#VRage_Game_MyAutorotateMode_FirstDirection)FirstDirection

When block has mountpoint on at least one side, it will autorotate so that this side is touching the surface. Otherwise, full range of rotations is allowed.

##### Declaration

```
public const MyAutorotateMode FirstDirection
```

##### Field Value

#### [](#VRage_Game_MyAutorotateMode_OneDirection)OneDirection

When block has mount points only on one side, it will autorotate so that side is touching the surface. Otherwise, full range of rotations is allowed.

##### Declaration

```
public const MyAutorotateMode OneDirection
```

##### Field Value

#### [](#VRage_Game_MyAutorotateMode_OppositeDirections)OppositeDirections

When block has mount points only on two sides and those sides are opposite each other (eg. Top and Bottom), it will autorotate so that one of these sides is touching the surface. Otherwise, full range of rotations is allowed.

##### Declaration

```
public const MyAutorotateMode OppositeDirections
```

##### Field Value

#### [](#VRage_Game_MyAutorotateMode_value__)value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |