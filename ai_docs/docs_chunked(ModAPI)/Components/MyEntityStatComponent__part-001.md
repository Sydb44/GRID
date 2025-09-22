---
title: "Class MyEntityStatComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyEntityStatComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyEntityStatComponent"
---

# Class MyEntityStatComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityStatComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyEntityStatComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent
```

### Constructors

#### MyEntityStatComponent()

##### Declaration

```
public MyEntityStatComponent()
```

### Fields

#### m\_scripts

##### Declaration

```
protected readonly Dictionary<string, MyStatLogic> m_scripts
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [MyStatLogic](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyStatLogic.html)\> |     |

### Properties

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### Stats

##### Declaration

```
public DictionaryValuesReader<MyStringHash, MyEntityStat> Stats { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html), [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html)\> |     |

### Methods

#### ApplyModifier(String)

##### Declaration

```
public void ApplyModifier(string modifierId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | modifierId |     |

#### CanDoAction(String, out MyTuple<UInt16, MyStringHash>, Boolean)

##### Declaration

```
public bool CanDoAction(string actionId, out MyTuple<ushort, MyStringHash> message, bool continuous = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | actionId |     |
| VRage.MyTuple<System.UInt16, [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | message |     |
| System.Boolean | continuous |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | objectBuilder |     |

##### Overrides

#### DoAction(String)

##### Declaration

```
public bool DoAction(string actionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | actionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetEfficiencyModifier(String)

##### Declaration

```
public float GetEfficiencyModifier(string modifierId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | modifierId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### HasAnyComsumableEffect(IEnumerable<MyEntityStatRegenEffect>)

##### Declaration

```
public bool HasAnyComsumableEffect(IEnumerable<MyEntityStatRegenEffect> ignored = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[MyEntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html)\> | ignored |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### TryGetStat(MyStringHash, out MyEntityStat)

##### Declaration

```
public bool TryGetStat(MyStringHash statId, out MyEntityStat outStat)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | statId |     |
| [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html) | outStat |     |
