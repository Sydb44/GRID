---
title: "Class CharacterMovementStateDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.CharacterMovementStateDelegate.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "CharacterMovementStateDelegate"
---

# Class CharacterMovementStateDelegate | Space Engineers ModAPI

##### Inheritance

System.Object

CharacterMovementStateDelegate

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class CharacterMovementStateDelegate : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_CharacterMovementStateDelegate__ctor_System_Object_System_IntPtr_)CharacterMovementStateDelegate(Object, IntPtr)

##### Declaration

```
public CharacterMovementStateDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_CharacterMovementStateDelegate_BeginInvoke_VRage_Game_MyCharacterMovementEnum_VRage_Game_MyCharacterMovementEnum_System_AsyncCallback_System_Object_)BeginInvoke(MyCharacterMovementEnum, MyCharacterMovementEnum, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyCharacterMovementEnum oldState, MyCharacterMovementEnum newState, AsyncCallback callback, object object)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#VRage_Game_ModAPI_CharacterMovementStateDelegate_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#VRage_Game_ModAPI_CharacterMovementStateDelegate_Invoke_VRage_Game_MyCharacterMovementEnum_VRage_Game_MyCharacterMovementEnum_)Invoke(MyCharacterMovementEnum, MyCharacterMovementEnum)

##### Declaration

```
public virtual void Invoke(MyCharacterMovementEnum oldState, MyCharacterMovementEnum newState)
```

##### Parameters