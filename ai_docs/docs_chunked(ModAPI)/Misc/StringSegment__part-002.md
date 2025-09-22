| Type | Name | Description |
| --- | --- | --- |
| System.String | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the string segment equals the string; `false` otherwise. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_EqualsIgnoreCase_VRage_Game_ModAPI_Ingame_Utilities_StringSegment_)EqualsIgnoreCase(StringSegment)

Compares this string segment with another in a case insensitive manner.

##### Declaration

```
public bool EqualsIgnoreCase(StringSegment other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the string segments are equal; `false` otherwise. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_GetHashCode)GetHashCode()

Returns the hash code for this instance.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | A 32-bit signed integer that is the hash code for this instance. |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_GetLines_System_Collections_Generic_List_System_String__)GetLines(List<String>)

Fills a list with individual strings representing the lines of text within this string segment, separated by newlines.

##### Declaration

```
public void GetLines(List<string> lines)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.String\> | lines |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_GetLines_System_Collections_Generic_List_VRage_Game_ModAPI_Ingame_Utilities_StringSegment__)GetLines(List<StringSegment>)

Fills a list with individual string segments representing the lines of text within this string segment, separated by newlines.

##### Declaration

```
public void GetLines(List<StringSegment> lines)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[StringSegment](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html)\> | lines |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_IndexOf_System_Char_)IndexOf(Char)

Reports the zero-based index of the first occurence of the specified character, relative to [Start](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Start). Returns -1 if nothing was found.

##### Declaration

```
public int IndexOf(char ch)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char | ch  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_IndexOf_System_Char_System_Int32_)IndexOf(Char, Int32)

Reports the zero-based index of the first occurence of the specified character, relative to [Start](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Start). Returns -1 if nothing was found.

##### Declaration

```
public int IndexOf(char ch, int start)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char | ch  |     |
| System.Int32 | start | Where to start the search (relative to [Start](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Start)) |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_IndexOfAny_System_Char___)IndexOfAny(Char\[\])

Reports the zero-based index of the first occurence of one of the provided characters, relative to [Start](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.Utilities.StringSegment.html#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_Start). Returns -1 if nothing was found.

##### Declaration

```
public int IndexOfAny(char[] chars)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Char\[\] | chars |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_Ingame_Utilities_StringSegment_ToString)ToString()

Returns a string containing just this segment.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |