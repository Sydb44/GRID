---
title: "Class CharacterMovementStateChangedDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateChangedDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "CharacterMovementStateChangedDelegate"
---

# Class CharacterMovementStateChangedDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

CharacterMovementStateChangedDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class CharacterMovementStateChangedDelegate : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_CharacterMovementStateChangedDelegate__ctor_System_Object_System_IntPtr_)CharacterMovementStateChangedDelegate(Object, IntPtr)

##### Declaration

```
public CharacterMovementStateChangedDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_CharacterMovementStateChangedDelegate_BeginInvoke_VRage_Game_ModAPI_IMyCharacter_VRage_Game_MyCharacterMovementEnum_VRage_Game_MyCharacterMovementEnum_System_AsyncCallback_System_Object_)BeginInvoke(IMyCharacter, MyCharacterMovementEnum, MyCharacterMovementEnum, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(IMyCharacter character, MyCharacterMovementEnum oldState, MyCharacterMovementEnum newState, AsyncCallback callback, object object)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#VRage_Game_ModAPI_CharacterMovementStateChangedDelegate_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#VRage_Game_ModAPI_CharacterMovementStateChangedDelegate_Invoke_VRage_Game_ModAPI_IMyCharacter_VRage_Game_MyCharacterMovementEnum_VRage_Game_MyCharacterMovementEnum_)Invoke(IMyCharacter, MyCharacterMovementEnum, MyCharacterMovementEnum)

##### Declaration

```
public virtual void Invoke(IMyCharacter character, MyCharacterMovementEnum oldState, MyCharacterMovementEnum newState)
```

##### Parameters