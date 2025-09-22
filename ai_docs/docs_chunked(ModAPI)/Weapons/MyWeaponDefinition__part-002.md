#### UseRandomizedRange

##### Declaration

```
public bool UseRandomizedRange
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WeaponAmmoDatas

##### Declaration

```
public MyWeaponDefinition.MyWeaponAmmoData[] WeaponAmmoDatas
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyWeaponDefinition.MyWeaponAmmoData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyWeaponDefinition.MyWeaponAmmoData.html)\[\] |     |

#### WeaponEffects

##### Declaration

```
public MyWeaponDefinition.MyWeaponEffect[] WeaponEffects
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyWeaponDefinition.MyWeaponEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyWeaponDefinition.MyWeaponEffect.html)\[\] |     |

### Properties

#### HasMissileAmmoDefined

##### Declaration

```
public bool HasMissileAmmoDefined { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasProjectileAmmoDefined

##### Declaration

```
public bool HasProjectileAmmoDefined { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetAmmoMagazineIdArrayIndex(MyDefinitionId)

##### Declaration

```
public int GetAmmoMagazineIdArrayIndex(MyDefinitionId ammoMagazineId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | ammoMagazineId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### HasAmmoMagazines()

##### Declaration

```
public bool HasAmmoMagazines()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasSpecificAmmoData(MyAmmoDefinition)

##### Declaration

```
public bool HasSpecificAmmoData(MyAmmoDefinition ammoDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyAmmoDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAmmoDefinition.html) | ammoDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides

#### IsAmmoMagazineCompatible(MyDefinitionId)

##### Declaration

```
public bool IsAmmoMagazineCompatible(MyDefinitionId ammoMagazineDefinitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | ammoMagazineDefinitionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |