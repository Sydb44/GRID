---
title: "Class MyLights"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLights.html"
category: "Blocks"
namespace: "Sandbox.Game.Lights"
class: "MyLights"
---

# Class MyLights | Space Engineers ModAPI

##### Inheritance

System.Object

MyLights

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Lights](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MySessionComponentDescriptor]
public class MyLights : MySessionComponentBase, IMyUserInputComponent
```

### Constructors

#### MyLights()

##### Declaration

### Methods

#### AddLight()

##### Declaration

```
public static MyLight AddLight()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyLight](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLight.html) |     |

#### LoadData()

##### Declaration

```
public override void LoadData()
```

##### Overrides

#### RemoveLight(MyLight)

##### Declaration

```
public static void RemoveLight(MyLight light)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLight](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Lights.MyLight.html) | light |     |

#### UnloadData()

##### Declaration

```
protected override void UnloadData()
```

##### Overrides