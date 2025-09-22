##### Declaration

```
public int ItemCount { get; }
```

##### Property Value

Type

Description

System.Int32

#### MaxItemCount

##### Declaration

```
public override int MaxItemCount { get; }
```

##### Property Value

Type

Description

System.Int32

##### Overrides

#### MaxMass

##### Declaration

```
public override MyFixedPoint MaxMass { get; }
```

##### Property Value

Type

Description

VRage.MyFixedPoint

##### Overrides

#### MaxVolume

##### Declaration

```
public override MyFixedPoint MaxVolume { get; set; }
```

##### Property Value

Type

Description

VRage.MyFixedPoint

##### Overrides

#### Owner

##### Declaration

```
public MyEntity Owner { get; }
```

##### Property Value

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### VolumeFillFactor

##### Declaration

```
public float VolumeFillFactor { get; }
```

##### Property Value

Type

Description

System.Single

### Methods

#### Add(IMyInventoryItem, MyFixedPoint)

##### Declaration

```
public override bool Add(IMyInventoryItem item, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html)

item

VRage.MyFixedPoint

amount

##### Returns

Type

Description

System.Boolean

##### Overrides

#### AddBlocks(MyCubeBlockDefinition, MyFixedPoint)

##### Declaration

```
public bool AddBlocks(MyCubeBlockDefinition blockDef, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDef

VRage.MyFixedPoint

amount

##### Returns

Type

Description

System.Boolean

#### AddItemClient(Int32, MyPhysicalInventoryItem)

##### Declaration

```
public void AddItemClient(int position, MyPhysicalInventoryItem item)
```

##### Parameters

Type

Name

Description

System.Int32

position

[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)

item

#### AddItems(MyFixedPoint, MyObjectBuilder\_Base)

##### Declaration

```
public override bool AddItems(MyFixedPoint amount, MyObjectBuilder_Base objectBuilder)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html)

objectBuilder

##### Returns

Type

Description

System.Boolean

##### Overrides

#### ApplyChanges(List<MyComponentChange>)

##### Declaration

```
public override void ApplyChanges(List<MyComponentChange> changes)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyComponentChange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyComponentChange.html)\>

changes

##### Overrides

#### CanItemsBeAdded(MyFixedPoint, MyDefinitionId)

##### Declaration

```
public bool CanItemsBeAdded(MyFixedPoint amount, MyDefinitionId contentId)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

##### Returns

Type

Description

System.Boolean

#### CanItemsBeAdded(MyFixedPoint, MyDefinitionId, MyFixedPoint, MyFixedPoint, MyFixedPoint, MyFixedPoint)

##### Declaration

```
public bool CanItemsBeAdded(MyFixedPoint amount, MyDefinitionId contentId, MyFixedPoint maxVolume, MyFixedPoint maxMass, MyFixedPoint currentVolume, MyFixedPoint currentMass)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

VRage.MyFixedPoint

maxVolume

VRage.MyFixedPoint

maxMass

VRage.MyFixedPoint

currentVolume

VRage.MyFixedPoint

currentMass

##### Returns

Type

Description

System.Boolean

#### ChangeItemClient(MyPhysicalInventoryItem, Int32)

##### Declaration

```
public void ChangeItemClient(MyPhysicalInventoryItem item, int position)
```

##### Parameters

Type

Name

Description

[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)

item

System.Int32

position

#### CheckConstraint(MyDefinitionId)

##### Declaration

```
public bool CheckConstraint(MyDefinitionId contentId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

##### Returns

Type

Description

System.Boolean

#### Clear(Boolean)

##### Declaration

```
public void Clear(bool sync = true)
```

##### Parameters

Type

Name

Description

System.Boolean

sync

#### ClearItems()

##### Declaration

#### ComputeAmountThatFits(MyBlueprintDefinitionBase)

##### Declaration

```
public MyFixedPoint ComputeAmountThatFits(MyBlueprintDefinitionBase blueprint)
```

##### Parameters

Type

Name

Description

[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)

blueprint

##### Returns

Type

Description

VRage.MyFixedPoint

#### ComputeAmountThatFits(MyDefinitionId, Single, Single)

##### Declaration

```
public override MyFixedPoint ComputeAmountThatFits(MyDefinitionId contentId, float volumeRemoved = 0F, float massRemoved = 0F)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

System.Single

volumeRemoved

System.Single

massRemoved

##### Returns

Type

Description

VRage.MyFixedPoint

##### Overrides

#### ConsumeItem(MyDefinitionId, MyFixedPoint, Int64)

##### Declaration

```
public override void ConsumeItem(MyDefinitionId itemId, MyFixedPoint amount, long consumerEntityId = 0L)
```
