```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

color

#### FogSetDensity(Single)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets density of fog.", -10510688)]
[VisualScriptingMember(true, false)]
public static void FogSetDensity(float density)
```

##### Parameters

Type

Name

Description

System.Single

density

#### FogSetMultiplier(Single)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets multiplier of fog.", -10510688)]
[VisualScriptingMember(true, false)]
public static void FogSetMultiplier(float multiplier)
```

##### Parameters

Type

Name

Description

System.Single

multiplier

#### FogSetSkyboxMultiplier(Single)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets skybox multiplier of fog.", -10510688)]
[VisualScriptingMember(true, false)]
public static void FogSetSkyboxMultiplier(float skyboxMultiplier)
```

##### Parameters

Type

Name

Description

System.Single

skyboxMultiplier

#### GetAdmins()

##### Declaration

```
[VisualScriptingMiscData("Player", "Get admins.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetAdmins()
```

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetAllCockpits(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Get all cockpits in the grid", -10510688)]
[VisualScriptingMember(false, false)]
public static List<string> GetAllCockpits(string gridName)
```

##### Parameters

Type

Name

Description

System.String

gridName

##### Returns

Type

Description

System.Collections.Generic.List<System.String\>

#### GetAllEntitiesInRay(Vector3D, Vector3D, out List<Single>)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns List of ids of entities in hit by a line", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetAllEntitiesInRay(Vector3D from, Vector3D to, out List<float> distances)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

from

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

to

System.Collections.Generic.List<System.Single\>

distances

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetBlockAttachedUpgradeModules(String, out Int32, out Int32, out Int32, out Int32, out Int32)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns ids of attached modules. Output parameters will contain additional informations.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetBlockAttachedUpgradeModules(string blockName, out int modulesCount, out int workingCount, out int slotsUsed, out int slotsTotal, out int incompatibleCount)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.Int32

modulesCount

System.Int32

workingCount

System.Int32

slotsUsed

System.Int32

slotsTotal

System.Int32

incompatibleCount

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetBlockHealth(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns current integrity of block in interval <0;1>.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetBlockHealth(string entityName, bool buildIntegrity = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

buildIntegrity

##### Returns

Type

Description

System.Single

#### GetColor(Single, Single, Single)

##### Declaration

```
[VisualScriptingMiscData("Misc", "Creates a new color out of red, green and blue. All values must be in range <0;1>.", -10510688)]
[VisualScriptingMember(false, false)]
public static Color GetColor(float r = 0F, float g = 0F, float b = 0F)
```

##### Parameters

Type

Name

Description

System.Single

r

System.Single

g

System.Single

b

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### GetContentPath()

##### Declaration

```
[VisualScriptingMiscData("Misc", "Returns path to where game content is located.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetContentPath()
```

##### Returns

Type

Description

System.String

#### GetControlByName(MyGuiControlParent, String)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets GUI element by name from the specific Gui element. You may search through hierarchy of controls by connecting element names with '\\'. Such as 'GrandParent\\Parent\\Child' will return element of name 'Child' that is under element 'Parent' that is under element 'GrandParent' which is in screen. In case specific element was not found, returned element will be the closest parent that was found.", -10510688)]
[VisualScriptingMember(false, false)]
public static MyGuiControlBase GetControlByName(this MyGuiControlParent control, string controlName)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlParent

control

System.String

controlName

##### Returns

Type

Description

Sandbox.Graphics.GUI.MyGuiControlBase

#### GetControlByName(MyGuiScreenBase, String)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets GUI element by name from the specific screen. You may search through hierarchy of controls by connecting element names with '\\\\'. Such as 'GrandParent\\\\Parent\\\\Child' will return element of name 'Child' that is under element 'Parent' that is under element 'GrandParent' which is in screen. In case specific element was not found, returned element will be the closest parent that was found.", -10510688)]
[VisualScriptingMember(false, false)]
public static MyGuiControlBase GetControlByName(this MyGuiScreenBase screen, string controlName)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiScreenBase

screen

System.String

controlName
