---
title: "Class MyCubeBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCubeBlock"
---

# Class MyCubeBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeBlock

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCubeBlock : MyEntity, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyCubeBlock, IMyEntity, IMyUpgradableBlock, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyCubeBlock()

##### Declaration

### Fields

#### CurrentAttachedUpgradeModules

##### Declaration

```
public Dictionary<long, MyCubeBlock.AttachedUpgradeModule> CurrentAttachedUpgradeModules
```

##### Field Value

Type

Description

System.Collections.Generic.Dictionary<System.Int64, [MyCubeBlock.AttachedUpgradeModule](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.AttachedUpgradeModule.html)\>

#### DUMMY\_SUBBLOCK\_ID

##### Declaration

```
protected static readonly string DUMMY_SUBBLOCK_ID
```

##### Field Value

Type

Description

System.String

#### HandleEmissiveStateChange

##### Declaration

```
public bool HandleEmissiveStateChange
```

##### Field Value

Type

Description

System.Boolean

#### InitSkinUpdateHandled

##### Declaration

```
public bool InitSkinUpdateHandled
```

##### Field Value

Type

Description

System.Boolean

#### IsBeingRemoved

##### Declaration

```
public bool IsBeingRemoved
```

##### Field Value

Type

Description

System.Boolean

#### IsSilenced

##### Declaration

##### Field Value

Type

Description

System.Boolean

#### m\_activeEffects

##### Declaration

```
protected List<MyCubeBlockEffect> m_activeEffects
```

##### Field Value

Type

Description

System.Collections.Generic.List<Sandbox.Game.ParticleEffects.MyCubeBlockEffect\>

#### m\_emissiveNames

##### Declaration

```
public static MyCubeBlock.EmissiveNames m_emissiveNames
```

##### Field Value

Type

Description

[MyCubeBlock.EmissiveNames](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.EmissiveNames.html)

#### m\_forceBlockDestructible

##### Declaration

```
protected bool m_forceBlockDestructible
```

##### Field Value

Type

Description

System.Boolean

#### m\_soundEmitter

##### Declaration

```
public MyEntity3DSoundEmitter m_soundEmitter
```

##### Field Value

Type

Description

[MyEntity3DSoundEmitter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntity3DSoundEmitter.html)

#### MAX\_CUSTOM\_NAME\_LENGTH

##### Declaration

```
public const int MAX_CUSTOM_NAME_LENGTH = 512
```

##### Field Value

Type

Description

System.Int32

#### SilenceInChange

##### Declaration

```
public bool SilenceInChange
```

##### Field Value

Type

Description

System.Boolean

#### SlimBlock

##### Declaration

```
public MySlimBlock SlimBlock
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### SubBlocks

Map from dummy name to subblock (subgrid, note that after grid split the subblock instance will be the same)

##### Declaration

```
protected Dictionary<string, MySlimBlock> SubBlocks
```

##### Field Value

Type

Description

System.Collections.Generic.Dictionary<System.String, Sandbox.Game.Entities.Cube.MySlimBlock\>

#### UsedUpdateEveryFrame

##### Declaration

```
public bool UsedUpdateEveryFrame
```

##### Field Value

Type

Description

System.Boolean

### Properties

#### BlockDefinition

##### Declaration

```
public MyCubeBlockDefinition BlockDefinition { get; }
```

##### Property Value

Type

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

#### BuiltBy

##### Declaration

```
public long BuiltBy { get; }
```

##### Property Value

Type

Description

System.Int64

#### CheckConnectionAllowed

##### Declaration

```
public bool CheckConnectionAllowed { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### CubeGrid

##### Declaration

```
public MyCubeGrid CubeGrid { get; }
```

##### Property Value

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### DefinitionDisplayNameText

##### Declaration

```
public string DefinitionDisplayNameText { get; }
```

##### Property Value

Type

Description

System.String

#### DisassembleRatio

##### Declaration

```
public virtual float DisassembleRatio { get; }
```

##### Property Value

Type

Description

System.Single

#### ForceBlockDestructible

##### Declaration

```
public bool ForceBlockDestructible { get; }
```

##### Property Value

Type

Description

System.Boolean

#### HasDamageEffect

##### Declaration

```
protected bool HasDamageEffect { get; }
```

##### Property Value

Type

Description

System.Boolean

#### HighlightMode

##### Declaration

```
public virtual MyCubeBlockHighlightModes HighlightMode { get; }
```

##### Property Value

Type

Description

[MyCubeBlockHighlightModes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlockHighlightModes.html)

#### IDModule

##### Declaration

```
public MyIDModule IDModule { get; }
```

##### Property Value

Type

Description

[MyIDModule](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyIDModule.html)

#### IsBeingHacked

##### Declaration

```
public virtual bool IsBeingHacked { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsBuilt

##### Declaration

```
public bool IsBuilt { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsFunctional

##### Declaration

```
public bool IsFunctional { get; }
```
