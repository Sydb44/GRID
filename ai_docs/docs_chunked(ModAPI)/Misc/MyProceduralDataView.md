---
title: "Class MyProceduralDataView"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralDataView.html"
category: "Misc"
namespace: "Sandbox.Game.WorldEnvironment"
class: "MyProceduralDataView"
---

# Class MyProceduralDataView | Space Engineers ModAPI

##### Inheritance

System.Object

MyProceduralDataView

##### Inherited Members

###### **Namespace**: [Sandbox.Game.WorldEnvironment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyProceduralDataView : MyEnvironmentDataView
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_WorldEnvironment_MyProceduralDataView__ctor_Sandbox_Game_WorldEnvironment_MyProceduralEnvironmentProvider_System_Int32_VRageMath_Vector2I__VRageMath_Vector2I__)MyProceduralDataView(MyProceduralEnvironmentProvider, Int32, ref Vector2I, ref Vector2I)

##### Declaration

```
public MyProceduralDataView(MyProceduralEnvironmentProvider provider, int lod, ref Vector2I start, ref Vector2I end)
```

##### Parameters

### [](#methods)Methods

#### [](#Sandbox_Game_WorldEnvironment_MyProceduralDataView_AddSector_Sandbox_Game_WorldEnvironment_MyProceduralLogicalSector_)AddSector(MyProceduralLogicalSector)

##### Declaration

```
public void AddSector(MyProceduralLogicalSector sector)
```

##### Parameters

#### [](#Sandbox_Game_WorldEnvironment_MyProceduralDataView_Close)Close()

##### Declaration

```
public override void Close()
```

##### Overrides

#### [](#Sandbox_Game_WorldEnvironment_MyProceduralDataView_GetSectorIndex_System_Int32_System_Int32_)GetSectorIndex(Int32, Int32)

##### Declaration

```
public int GetSectorIndex(int x, int y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |