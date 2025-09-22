#### ClearImagesFromSelection()

Removes images from shown images.

##### Declaration

```
void ClearImagesFromSelection()
```

#### DrawFrame()

Creates a new draw frame where you can add sprites to be rendered.

##### Declaration

```
MySpriteDrawFrame DrawFrame()
```

##### Returns

| Type | Description |
| --- | --- |
| [MySpriteDrawFrame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.GUI.TextPanel.MySpriteDrawFrame.html) |     |

#### GetFonts(List<String>)

Gets a list of available fonts

##### Declaration

```
void GetFonts(List<string> fonts)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | fonts |     |

#### GetScripts(List<String>)

Gets a list of available scripts

##### Declaration

```
void GetScripts(List<string> scripts)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | scripts |     |

#### GetSelectedImages(List<String>)

Outputs the selected image ids to the specified list.

NOTE: List is not cleared internally.

##### Declaration

```
void GetSelectedImages(List<string> output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | output | Image id's would be written into this array |

#### GetSprites(List<String>)

Gets a list of available sprites

##### Declaration

```
void GetSprites(List<string> sprites)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | sprites | Buffer array that would be filled with available sprites |

#### GetText()

Gets current text that is written on surface. Allocates memory (StringBuilder.ToString())! This method doesn't allocate memory [ReadText(StringBuilder, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTextSurface.html#Sandbox_ModAPI_Ingame_IMyTextSurface_ReadText_System_Text_StringBuilder_System_Boolean_)

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String | Current text |

#### MeasureStringInPixels(StringBuilder, String, Single)

Calculates how many pixels a string of a given font and scale will take up.

##### Declaration

```
Vector2 MeasureStringInPixels(StringBuilder text, string font, float scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | text | Text to measure |
| System.String | font | Text font to measure |
| System.Single | scale | Text scale to measure |

##### Returns

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | Width and Height of text with specified text, font and scale |

#### ReadText(StringBuilder, Boolean)

Gets current text that is written on surface.

##### Declaration

```
void ReadText(StringBuilder buffer, bool append = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | buffer | Where to write text |
| System.Boolean | append | If true, text would be appended, else buffer would be cleared before text append |

#### RemoveImageFromSelection(String, Boolean)

Removes image from shown images.

##### Declaration

```
void RemoveImageFromSelection(string id, bool removeDuplicates = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | id  | Id of image |
| System.Boolean | removeDuplicates |     |

#### RemoveImagesFromSelection(List<String>, Boolean)

Removes images from shown images.

##### Declaration

```
void RemoveImagesFromSelection(List<string> ids, bool removeDuplicates = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | ids | Images ids |
| System.Boolean | removeDuplicates | If true, would remove all images with provided ids |

#### WriteText(String, Boolean)

Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

##### Declaration

```
bool WriteText(string value, bool append = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | value | Text to append |
| System.Boolean | append | If true, appends, else replaces text with `<code data-dev-comment-type="paramref" class="paramref">value</code>` |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if text was added, or replaced. False if somebody was looking at lcd |

#### WriteText(StringBuilder, Boolean)

Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols

##### Declaration

```
bool WriteText(StringBuilder value, bool append = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Text.StringBuilder | value | Text to append |
| System.Boolean | append | If true, appends, else replaces text with `<code data-dev-comment-type="paramref" class="paramref">value</code>` |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if text was added, or replaced. False if somebody was looking at lcd |