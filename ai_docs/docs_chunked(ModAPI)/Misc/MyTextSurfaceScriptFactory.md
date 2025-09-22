---
title: "Class MyTextSurfaceScriptFactory"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptFactory.html"
category: "Misc"
namespace: "Sandbox.Game.GameSystems.TextSurfaceScripts"
class: "MyTextSurfaceScriptFactory"
---

# Class MyTextSurfaceScriptFactory | Space Engineers ModAPI

##### Inheritance

System.Object

MyTextSurfaceScriptFactory

###### **Namespace**: [Sandbox.Game.GameSystems.TextSurfaceScripts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyTextSurfaceScriptFactory : Object
```

### Constructors

#### MyTextSurfaceScriptFactory()

##### Declaration

```
public MyTextSurfaceScriptFactory()
```

### Properties

#### Instance

##### Declaration

```
public static MyTextSurfaceScriptFactory Instance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTextSurfaceScriptFactory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptFactory.html) |     |

#### Scripts

##### Declaration

```
public DictionaryReader<string, MyTextSurfaceScriptFactory.ScriptInfo> Scripts { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, [MyTextSurfaceScriptFactory.ScriptInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptFactory.ScriptInfo.html)\> |     |

### Methods

#### CreateScript(String, IMyTextSurface, IMyCubeBlock, Vector2)

##### Declaration

```
public static IMyTextSurfaceScript CreateScript(string id, IMyTextSurface surface, IMyCubeBlock block, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  |     |
| [IMyTextSurface](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html) | surface |     |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyTextSurfaceScript](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript.html) |     |

#### LoadScripts()

##### Declaration

```
public static void LoadScripts()
```

#### RegisterFromAssembly(IEnumerable<Assembly>)

##### Declaration

```
public void RegisterFromAssembly(IEnumerable<Assembly> assemblies)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<System.Reflection.Assembly\> | assemblies |     |

#### RegisterFromAssembly(Assembly)

##### Declaration

```
public void RegisterFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |

#### UnloadScripts()

##### Declaration

```
public static void UnloadScripts()
```