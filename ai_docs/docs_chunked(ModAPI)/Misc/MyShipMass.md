---
title: "Class MyShipMass"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipMass.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "MyShipMass"
---

# Class MyShipMass | Space Engineers ModAPI

Describes ship mass

##### Inheritance

System.Object

MyShipMass

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyShipMass : ValueType
```

### Constructors

#### MyShipMass(Single, Single, Single)

Implements constructor of MyShipMass

##### Declaration

```
public MyShipMass(float mass, float totalMass, float physicalMass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | mass | mass |
| System.Single | totalMass | total mass |
| System.Single | physicalMass | physical mass |

### Fields

#### BaseMass

Gets the base mass of the ship.

##### Declaration

```
public readonly float BaseMass
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PhysicalMass

Gets the physical mass of the ship, which accounts for inventory multiplier.

##### Declaration

```
public readonly float PhysicalMass
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TotalMass

Gets the total mass of the ship, including cargo.

##### Declaration

```
public readonly float TotalMass
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |