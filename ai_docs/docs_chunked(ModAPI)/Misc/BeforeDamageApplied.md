---
title: "Class BeforeDamageApplied"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.BeforeDamageApplied.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "BeforeDamageApplied"
---

# Class BeforeDamageApplied | Space Engineers ModAPI

This delegate is used to handle damage before it's applied to an object. This returns a modified damage that is used in DoDamage. Return damage if no change.

##### Inheritance

System.Object

BeforeDamageApplied

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class BeforeDamageApplied : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#VRage_Game_ModAPI_BeforeDamageApplied__ctor_System_Object_System_IntPtr_)BeforeDamageApplied(Object, IntPtr)

##### Declaration

```
public BeforeDamageApplied(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_BeforeDamageApplied_BeginInvoke_System_Object_VRage_Game_ModAPI_MyDamageInformation__System_AsyncCallback_System_Object_)BeginInvoke(Object, ref MyDamageInformation, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(object target, ref MyDamageInformation info, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | target |     |
| [MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html) | info |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#VRage_Game_ModAPI_BeforeDamageApplied_EndInvoke_VRage_Game_ModAPI_MyDamageInformation__System_IAsyncResult_)EndInvoke(ref MyDamageInformation, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref MyDamageInformation info, IAsyncResult result)
```

##### Parameters

#### [](#VRage_Game_ModAPI_BeforeDamageApplied_Invoke_System_Object_VRage_Game_ModAPI_MyDamageInformation__)Invoke(Object, ref MyDamageInformation)

##### Declaration

```
public virtual void Invoke(object target, ref MyDamageInformation info)
```

##### Parameters