| Type | Description |
| --- | --- |
| VRage.Generics.IMyVariableStorage<System.Single\> |     |

### [](#methods)Methods

#### [](#VRage_Game_Components_MyAnimationControllerComponent_ApplyVariables)ApplyVariables()

##### Declaration

```
public void ApplyVariables()
```

#### [](#VRage_Game_Components_MyAnimationControllerComponent_AttachAnimationEventCallback_System_Action_System_Collections_Generic_List_System_String___)AttachAnimationEventCallback(Action<List<String>>)

##### Declaration

```
public void AttachAnimationEventCallback(Action<List<string>> action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<System.Collections.Generic.List<System.String\>> | action |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_Clear)Clear()

##### Declaration

#### [](#VRage_Game_Components_MyAnimationControllerComponent_DetachAnimationEventCallback_System_Action_System_Collections_Generic_List_System_String___)DetachAnimationEventCallback(Action<List<String>>)

##### Declaration

```
public void DetachAnimationEventCallback(Action<List<string>> action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<System.Collections.Generic.List<System.String\>> | action |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_FindBone_System_String_System_Int32__)FindBone(String, out Int32)

##### Declaration

```
public MyCharacterBone FindBone(string name, out int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| VRageRender.Animations.MyCharacterBone |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_FinishUpdate)FinishUpdate()

##### Declaration

```
public void FinishUpdate()
```

#### [](#VRage_Game_Components_MyAnimationControllerComponent_GetKeyedAnimationTracks_System_String_)GetKeyedAnimationTracks(String)

##### Declaration

```
public List<MyAnimationTreeNode> GetKeyedAnimationTracks(string key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<VRageRender.Animations.MyAnimationTreeNode\> |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_MarkAsValid)MarkAsValid()

##### Declaration

```
public void MarkAsValid()
```

#### [](#VRage_Game_Components_MyAnimationControllerComponent_OnAddedToContainer)OnAddedToContainer()

Component was added in the entity component container.

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### [](#VRage_Game_Components_MyAnimationControllerComponent_OnBeforeRemovedFromContainer)OnBeforeRemovedFromContainer()

Component will be removed from entity component container.

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### [](#VRage_Game_Components_MyAnimationControllerComponent_SetCharacterBones_VRageRender_Animations_MyCharacterBone___VRageMath_Matrix___VRageMath_Matrix___)SetCharacterBones(MyCharacterBone\[\], Matrix\[\], Matrix\[\])

##### Declaration

```
public void SetCharacterBones(MyCharacterBone[] characterBones, Matrix[] relativeTransforms, Matrix[] absoluteTransforms)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.Animations.MyCharacterBone\[\] | characterBones |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)\[\] | relativeTransforms |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)\[\] | absoluteTransforms |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_TriggerAction_VRage_Utils_MyStringId_System_String___)TriggerAction(MyStringId, String\[\])

Trigger an action in the layers specified. If no layers are specified, it is triggered for all instead. If there is a transition having given (non-null) name, it is followed immediatelly. Conditions of transition are ignored. This is a shortcut to Controller.TriggerAction.

##### Declaration

```
public void TriggerAction(MyStringId actionName, string[] layers = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | actionName |     |
| System.String\[\] | layers |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_Update)Update()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_Components_MyAnimationControllerComponent_UpdateInverseKinematics)UpdateInverseKinematics()

##### Declaration

```
public void UpdateInverseKinematics()
```

#### [](#VRage_Game_Components_MyAnimationControllerComponent_UpdateTransformations)UpdateTransformations()

##### Declaration

```
public void UpdateTransformations()
```

### [](#events)Events

#### [](#VRage_Game_Components_MyAnimationControllerComponent_ActionTriggered)ActionTriggered

##### Declaration

```
public event Action<MyStringId> ActionTriggered
```

##### Event Type

### [](#extensionmethods)Extension Methods