---
title: "Interface IMyShootOrigin"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyShootOrigin.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyShootOrigin"
---

# Interface IMyShootOrigin | Space Engineers ModAPI

Interface describing part of weapon block logic Used in detection if target is visible

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyShootOrigin
```

### Properties

#### GetAmmoDefinition

Gets ammo definition

##### Declaration

```
MyDefinitionBase GetAmmoDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) |     |

#### MaxShootRange

Gets weapon max shoot range

##### Declaration

```
float MaxShootRange { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ShootOrigin

Gets shot starting position

##### Declaration

```
Vector3D ShootOrigin { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |