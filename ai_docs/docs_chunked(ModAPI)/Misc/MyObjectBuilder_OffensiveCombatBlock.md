---
title: "Class MyObjectBuilder\\_OffensiveCombatBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_OffensiveCombatBlock.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_OffensiveCombatBlock"
---

# Class MyObjectBuilder\_OffensiveCombatBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_OffensiveCombatBlock

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_OffensiveCombatBlock : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_OffensiveCombatBlock()

##### Declaration

```
public MyObjectBuilder_OffensiveCombatBlock()
```

### Fields

#### CanTargetCharacters

##### Declaration

```
public bool CanTargetCharacters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PrevToolbarState

##### Declaration

```
[Nullable]
public Nullable<bool> PrevToolbarState
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### SelectedAttackPattern

##### Declaration

```
public long SelectedAttackPattern
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### TargetPriority

##### Declaration

```
public OffensiveCombatTargetPriority TargetPriority
```

##### Field Value

| Type | Description |
| --- | --- |
| [OffensiveCombatTargetPriority](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.OffensiveCombatTargetPriority.html) |     |

#### Toolbar

##### Declaration

```
[Nullable]
public MyObjectBuilder_Toolbar Toolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

#### UpdateTargetInterval

##### Declaration

```
public int UpdateTargetInterval
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

#### SetupForGridPaste()

##### Declaration

```
public override void SetupForGridPaste()
```

##### Overrides

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

### Extension Methods