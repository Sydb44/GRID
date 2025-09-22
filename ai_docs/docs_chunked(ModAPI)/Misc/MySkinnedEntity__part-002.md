```
public virtual void ObtainBones()
```

#### OnAnimationPlay(MyAnimationDefinition, MyAnimationCommand, ref String, ref MyFrameOption, ref Boolean)

Virtual method called when animation is started, used in MyCharacter.

##### Declaration

```
protected virtual void OnAnimationPlay(MyAnimationDefinition animDefinition, MyAnimationCommand command, ref string bonesArea, ref MyFrameOption frameOption, ref bool useFirstPersonVersion)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Definitions.Animation.MyAnimationDefinition | animDefinition |     |
| [MyAnimationCommand](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAnimationCommand.html) | command |     |
| System.String | bonesArea |     |
| [MyFrameOption](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFrameOption.html) | frameOption |     |
| System.Boolean | useFirstPersonVersion |     |

#### ProcessCommands()

Process all commands in the animation queue at once. If any command is generated during flushing, it will be processed later.

##### Declaration

```
protected bool ProcessCommands()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SetBoneLODs(Dictionary<Single, String\[\]>)

##### Declaration

```
public void SetBoneLODs(Dictionary<float, string[]> boneLODs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<System.Single, System.String\[\]> | boneLODs |     |

#### TryGetAnimationDefinition(String, out MyAnimationDefinition)

Try getting animation definition matching given subtype name. VRage TODO: dependency on MyDefinitionManager, do we really need it here? backward compatibility is for modders? move backward compatibility to MyDefinitionManager.TryGetAnimationDefinition? then we do not need this method

marked as obsolete, needs to be resolved

##### Declaration

```
protected bool TryGetAnimationDefinition(string animationSubtypeName, out MyAnimationDefinition animDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | animationSubtypeName |     |
| VRage.Game.Definitions.Animation.MyAnimationDefinition | animDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UpdateAfterSimulationParallel()

##### Declaration

```
public virtual void UpdateAfterSimulationParallel()
```

#### UpdateAnimation(Single)

##### Declaration

```
public virtual void UpdateAnimation(float distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | distance |     |

#### UpdateBeforeSimulationParallel()

##### Declaration

```
public virtual void UpdateBeforeSimulationParallel()
```

#### UpdateControl(Single)

##### Declaration

```
public virtual void UpdateControl(float distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | distance |     |

#### UpdateRenderObject()

##### Declaration

```
protected void UpdateRenderObject()
```

### Implements

### Extension Methods