void GetSurfaceAndMaterial(IMyEntity entity, ref LineD line, ref Vector3D hitPosition, uint shapeKey, out MySurfaceImpactEnum surfaceImpact, out MyStringHash materialType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that was hitted |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line | Part of bullet trajectory |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | hitPosition | World position of hit |
| System.UInt32 | shapeKey | Should be taken from [HitShapeKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileHitInfo.html#Sandbox_ModAPI_MyProjectileHitInfo_HitShapeKey) |
| [MySurfaceImpactEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MySurfaceImpactEnum.html) | surfaceImpact | Returns surface, that bullet hitted |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | materialType | Returns material, that bullet hitted |

#### MarkProjectileForDestroy(Int32)

Marks projectiles for destroy, doesn't decrease projectiles count. Shifting projectiles id, on next frame

##### Declaration

```
void MarkProjectileForDestroy(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | index of projectile |

#### remove\_OnProjectileAdded(OnProjectileAddedRemoved)

##### Declaration

```
void remove_OnProjectileAdded(OnProjectileAddedRemoved value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [OnProjectileAddedRemoved](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.OnProjectileAddedRemoved.html) | value |     |

#### remove\_OnProjectileRemoving(OnProjectileAddedRemoved)

##### Declaration

```
void remove_OnProjectileRemoving(OnProjectileAddedRemoved value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [OnProjectileAddedRemoved](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.OnProjectileAddedRemoved.html) | value |     |

#### RemoveHitDetector(IMyProjectileDetector)

Removes projectile detector

##### Declaration

```
void RemoveHitDetector(IMyProjectileDetector detector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyProjectileDetector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyProjectileDetector.html) | detector | Detector logic |

#### RemoveOnHitInterceptor(HitInterceptor)

Removed function from call when projectile hits something

##### Declaration

```
void RemoveOnHitInterceptor(HitInterceptor interceptor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [HitInterceptor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.HitInterceptor.html) | interceptor | Function that should not be called on projectile hit |

### Events

#### OnProjectileAdded

Called when new projectile was added

##### Declaration

```
event OnProjectileAddedRemoved OnProjectileAdded
```

##### Event Type

| Type | Description |
| --- | --- |
| [OnProjectileAddedRemoved](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.OnProjectileAddedRemoved.html) |     |

#### OnProjectileRemoving

Called when projectile was removed

##### Declaration

```
event OnProjectileAddedRemoved OnProjectileRemoving
```

##### Event Type

| Type | Description |
| --- | --- |
| [OnProjectileAddedRemoved](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.OnProjectileAddedRemoved.html) |     |