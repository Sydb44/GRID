# Space Engineers ModAPI Documentation Index

This documentation contains 2,887 reference files from the Space Engineers ModAPI, organized for optimal LLM retrieval.

## 📁 Categories

### 🔧 **Blocks** (63 files)
Core block interfaces and implementations for doors, lights, sensors, and basic functionality.
- Door controls: `IMyDoor`, `IMyAdvancedDoor`, `IMyAirtightHangarDoor`
- Lighting: `IMyLightingBlock`, `IMyInteriorLight`, `IMyReflectorLight`
- Sensors: `IMySensorBlock`

### ⚡ **Power** (39 files)
Power generation, storage, and management systems.
- Battery systems: `IMyBatteryBlock`, `MyObjectBuilder_BatteryBlock`
- Solar panels: `IMySolarPanel`, `MyObjectBuilder_SolarPanel`
- Reactors: `IMyReactor`, `MyObjectBuilder_Reactor`
- Hydrogen engines: `IMyHydrogenEngine`

### 🏭 **Production** (20 files)
Manufacturing and refining systems.
- Assemblers: `IMyAssembler`, `MyObjectBuilder_Assembler`
- Refineries: `IMyRefinery`, `MyObjectBuilder_Refinery`
- Oxygen generators: `IMyOxygenGenerator`

### ✈️ **Flight** (21 files)
Ship movement and control systems.
- Thrusters: `IMyThrust`, `MyObjectBuilder_Thrust`
- Gyroscopes: `IMyGyro`, `MyObjectBuilder_Gyro`
- Cockpits: `IMyCockpit`, `MyObjectBuilder_Cockpit`

### 🚛 **Logistics** (30 files)
Cargo, conveyor, and transportation systems.
- Conveyors: `IMyConveyor`, `MyObjectBuilder_Conveyor`
- Connectors: `IMyShipConnector`
- Collectors: `IMyCollector`

### 🔫 **Weapons** (68 files)
Combat systems, turrets, and weaponry.
- Turrets: `IMyTurretControlBlock`, `IMyLargeGatlingTurret`
- Weapons: `IMySmallMissileLauncher`, `IMySmallGatlingGun`
- Combat blocks: `IMyOffensiveCombatBlock`, `IMyDefensiveCombatBlock`

### 🧬 **Life-Support** (15 files)
Life support, medical, and survival systems.
- Medical rooms: `IMyMedicalRoom`
- Oxygen systems: `IMyOxygenProvider`, `IMyOxygenTank`
- Survival kits: `IMySurvivalKit`

### 🤖 **AI** (11 files)
Artificial intelligence, autopilot, and automation systems.
- Autopilot: `IMyAutopilotWaypoint`, `IMyBasicMissionAutopilot`
- AI behaviors: `MyObjectBuilder_AutopilotBase`

### ⚙️ **Components** (371 files)
Low-level components, systems, and building blocks.
- Entity components: Various `IMyEntityComponent` implementations
- Game logic components: Various `MyObjectBuilder_*Component` classes
- Specialized systems: Lighting, sound, particle effects

### 📡 **Events** (112 files)
Event handling, triggers, and condition systems.
- Block events: `MyObjectBuilder_EventBlockAddedRemoved`
- Condition events: Various trigger and state change events
- System events: Grid, power, and connectivity events

### 🔧 **Misc** (2,137 files)
General utilities, data structures, math helpers, and core framework.
- Core interfaces: `IMyCubeGrid`, `IMyEntity`, `IMyPlayer`
- Math and geometry: `Vector3D`, `BoundingBoxD`, `MatrixD`
- Game systems: `IMySession`, `IMyMultiplayer`, `IMyPhysics`
- Utilities: Collections, helpers, definitions

## 🔍 Key Interfaces for Mod Development

### Essential Block Interfaces
```
IMyCubeBlock          - Base interface for all blocks
IMyFunctionalBlock    - Base for functional blocks
IMyTerminalBlock      - Base for blocks with terminal access
```

### Programmable Block Development
```
IMyProgrammableBlock       - Programmable block interface
IMyGridProgram            - Your script's main interface
IMyGridTerminalSystem     - Access terminal blocks
IMyGridProgramRuntimeInfo - Runtime and performance info
```

### Common Block Categories
```
Power:        IMyBatteryBlock, IMyReactor, IMySolarPanel
Production:   IMyAssembler, IMyRefinery, IMyOxygenGenerator
Flight:       IMyThrust, IMyGyro, IMyCockpit
Logistics:    IMyConveyor, IMyShipConnector, IMyCollector
Weapons:      IMyTurretControlBlock, IMySmallMissileLauncher
```

## 📖 Usage Tips

1. **Start with categories**: Use the category folders to find related functionality
2. **Interface inheritance**: Most blocks inherit from `IMyTerminalBlock` or `IMyFunctionalBlock`
3. **Object builders**: `MyObjectBuilder_*` classes are used for serialization and definitions
4. **Mod API vs Game API**: Files under `Sandbox.ModAPI.*` are for mods, `Sandbox.Game.*` for internal use

## 🔗 Original Documentation
All content sourced from: https://keensoftwarehouse.github.io/SpaceEngineersModAPI/

---
*Generated from Space Engineers ModAPI documentation - 2,887 reference files*
