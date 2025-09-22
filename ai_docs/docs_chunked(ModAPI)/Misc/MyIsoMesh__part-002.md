
##### Declaration

```
public void Reserve(int vertexCount, int triangleCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | vertexCount |     |
| System.Int32 | triangleCount |     |

#### Resize(Int32, Int32)

##### Declaration

```
public void Resize(int vertexCount, int triangleCount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | vertexCount |     |
| System.Int32 | triangleCount |     |

#### WriteTriangle(Int32, Int32, Int32)

##### Declaration

```
public void WriteTriangle(int v0, int v1, int v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | v0  |     |
| System.Int32 | v1  |     |
| System.Int32 | v2  |     |

#### WriteVertex(ref Vector3I, ref Vector3, ref Vector3, Byte, UInt32)

##### Declaration

```
public int WriteVertex(ref Vector3I cell, ref Vector3 position, ref Vector3 normal, byte material, uint colorShift)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | cell |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | position |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |
| System.Byte | material |     |
| System.UInt32 | colorShift |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |