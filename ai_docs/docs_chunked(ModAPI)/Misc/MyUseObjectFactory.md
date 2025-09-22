---
title: "Class MyUseObjectFactory"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.MyUseObjectFactory.html"
category: "Misc"
namespace: "VRage.Game.Entity.UseObject"
class: "MyUseObjectFactory"
---

# Class MyUseObjectFactory | Space Engineers ModAPI

##### Inheritance

System.Object

MyUseObjectFactory

###### **Namespace**: [VRage.Game.Entity.UseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[PreloadRequired]
public static class MyUseObjectFactory : Object
```

### Methods

#### CreateUseObject(String, IMyEntity, String, MyModelDummy, UInt32)

##### Declaration

```
public static IMyUseObject CreateUseObject(string detectorName, IMyEntity owner, string dummyName, MyModelDummy dummyData, uint shapeKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | detectorName |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | owner |     |
| System.String | dummyName |     |
| VRageRender.Import.MyModelDummy | dummyData |     |
| System.UInt32 | shapeKey |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyUseObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.UseObject.IMyUseObject.html) |     |

#### RegisterAssemblyTypes(Assembly)

##### Declaration

```
public static void RegisterAssemblyTypes(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |

#### RegisterAssemblyTypes(Assembly\[\])

##### Declaration

```
public static void RegisterAssemblyTypes(Assembly[] assemblies)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly\[\] | assemblies |     |

#### RestoreBaseGamePreset()

##### Declaration

```
public static void RestoreBaseGamePreset()
```