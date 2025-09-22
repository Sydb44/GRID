---
title: "Class MyAPIGateway"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyAPIGateway.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyAPIGateway"
---

# Class MyAPIGateway | Space Engineers ModAPI

This is entry point for entire scripting possibilities in game

##### Inheritance

System.Object

MyAPIGateway

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public static class MyAPIGateway : Object
```

### Fields

#### ContractSystem

IMyContractSystem allows you add or edit contracts

##### Declaration

```
public static IMyContractSystem ContractSystem
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyContractSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyContractSystem.html) |     |

#### CubeBuilder

IMyCubeBuilder represents building hand

##### Declaration

```
public static IMyCubeBuilder CubeBuilder
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyCubeBuilder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeBuilder.html) |     |

#### DLC

Provides access for checking installation state of DLCs, and if DLC required by a definition is present.

##### Declaration

```
public static IMyDLCs DLC
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyDLCs](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyDLCs.html) |     |

#### GravityProviderSystem

Provides access to gravity control

##### Declaration

```
public static IMyGravityProviderSystem GravityProviderSystem
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyGravityProviderSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGravityProviderSystem.html) |     |

#### GridGroups

Provides access to the Grid Group system

##### Declaration

```
public static IMyGridGroups GridGroups
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyGridGroups](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroups.html) |     |

#### Gui

IMyGui exposes some useful values from the GUI systems

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [IMyGui](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGui.html) |     |

#### GuiControlCreated

Obsolete

##### Declaration

```
public static Action<object> GuiControlCreated
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Action<System.Object\> |     |

#### IngameScripting

Provides mod access to control compilation of ingame scripts

##### Declaration

```
public static IMyIngameScripting IngameScripting
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyIngameScripting](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyIngameScripting.html) |     |

#### Input

IMyInput allows accessing direct input device states

##### Declaration

```
public static IMyInput Input
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.ModAPI.IMyInput |     |

#### Missiles

Interface for controlling missiles

##### Declaration

```
public static IMyMissiles Missiles
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyMissiles](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissiles.html) |     |

#### Multiplayer

IMyMultiplayer contains multiplayer related things

##### Declaration

```
public static IMyMultiplayer Multiplayer
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyMultiplayer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyMultiplayer.html) |     |

#### Parallel

IMyParallelTask allows to run tasks on background threads

##### Declaration

```
public static IMyParallelTask Parallel
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyParallelTask](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyParallelTask.html) |     |

#### Physics

IMyPhysics contains physics related things (CastRay, etc.)

##### Declaration

```
public static IMyPhysics Physics
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyPhysics](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html) |     |

#### Players

IMyPlayerCollection contains all players that are in world

##### Declaration

```
public static IMyPlayerCollection Players
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyPlayerCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayerCollection.html) |     |

#### PrefabManager

Allows you spawn prefabs

##### Declaration

```
public static IMyPrefabManager PrefabManager
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyPrefabManager](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPrefabManager.html) |     |

#### Projectiles

Interface for controlling projectile behavior

##### Declaration

```
public static IMyProjectiles Projectiles
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyProjectiles](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyProjectiles.html) |     |

#### Reflection

Allows you to use some reflection tools

##### Declaration

```
public static IMyReflection Reflection
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMyReflection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyReflection.html) |     |

#### SpectatorTools

Gives you access to spectator tools.

##### Declaration

```
public static IMySpectatorTools SpectatorTools
```

##### Field Value

| Type | Description |
| --- | --- |
| [IMySpectatorTools](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySpectatorTools.html) |     |
