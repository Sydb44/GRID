Adds a "Convert to Station" button to grid's [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen"). Also allows pasted static grids to remain static even if not touching any voxel.

#### Enable Voxel Destruction

Controls whether voxels (that is, the ground and asteroids) are destructable by drills, collisions, or explosives. Typically enabled for Survival games, and disabled for adventure maps or showcases. Enabled by default. See also [Damage Mechanics](https://spaceengineers.wiki.gg/wiki/Damage_Mechanics "Damage Mechanics").

#### Allow Remote Block Removal

Allows players to free up their [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") limit by remotely removing their own abandoned [grids](https://spaceengineers.wiki.gg/wiki/Grid "Grid") through the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen") of their player Terminal. Enabled by default.

#### Enable Scrap Drops

Allow recyclable [Scrap Metal](https://spaceengineers.wiki.gg/wiki/Scrap_Metal "Scrap Metal") to be dropped from destroyed blocks. Disable this to improve performance of battle fields or crash sites.

#### Enable Temporary Containers

Combines multiple floating items, such as the contents of a destroyed cargo container, into one item called [Temporary Container](https://spaceengineers.wiki.gg/wiki/Temporary_Container "Temporary Container"). Enable this to improve performance in world with lots of debris, e.g. on battle fields.

### Experimental Settings

These settings are (almost all) disabled by default.

#### Enable In-Game scripts

Enable this to run [scripts](https://spaceengineers.wiki.gg/wiki/Scripting "Scripting") in [Programmable Blocks](https://spaceengineers.wiki.gg/wiki/Programmable_Block "Programmable Block"). Disabled by default.

Important if you are using [Mechanical Blocks](https://spaceengineers.wiki.gg/wiki/Mechanical_Blocks "Mechanical Blocks") in general to prevent shaking. Formerly part of [Experimental mode](https://spaceengineers.wiki.gg/wiki/Experimental_mode "Experimental mode"). Turned off by default.

#### Enable Unsafe Piston Impulses

Important if you use certain extreme piston settings. Formerly part of [Experimental mode](https://spaceengineers.wiki.gg/wiki/Experimental_mode "Experimental mode"). Turned off by default.

#### Enable Unsafe Torques

Used to be called "unsafe rotor impulses". Important if you are using [rotors](https://spaceengineers.wiki.gg/wiki/Rotor "Rotor") in extreme states. Formerly part of [Experimental mode](https://spaceengineers.wiki.gg/wiki/Experimental_mode "Experimental mode"). Turned off by default.

#### Unsupported Stations

If disabled (default), when you disconnect the supports of a static [grid](https://spaceengineers.wiki.gg/wiki/Grid "Grid") from a planet or asteroid, it will turn into mobile grid. If enabled, the static grid will remain static even if there's no physical voxel supports. Sometimes grids remain static even if this is off, see the [bug report](https://support.keenswh.com/spaceengineers/pc/topic/physics-not-updating-unsupported-stations).

#### Adaptive Simulation Quality

If enabled and the local CPU is past 90% usage sustained, a few things stop happening: block deformation, some voxel cutouts, voxel cutouts from explosions, projectiles update less frequently, [character limbs and ragdolls](https://en.wikipedia.org/wiki/Inverse_kinematics%7CIK) stop animating, some grid impact details. Enabled by default.

#### Permanent Death

If enabled, the engineer cannot respawn in this game save anymore after they die. Permadeath is disabled by default.

#### Reset Ownership

If turned on, upon world load it will reset the [Ownership](https://spaceengineers.wiki.gg/wiki/Ownership "Ownership") of all blocks to "nobody" and share mode to "none", then the Reset Ownership turns itself off.

#### Allow Sub-grid Damage

If enabled, then [subgrids](https://spaceengineers.wiki.gg/wiki/Grid "Grid") connected by hinges/rotors/pistons can damage each other when moving. Disabled by default for more stable behaviour.

#### Enable Supergridding

If enabled, allows blocks to spawn on the wrong grid size (can't be done in game, requires editing the blueprint file). This used to be an exploit that was creatively used by some workshop builds, which is why it's an option now. Disabled by default. See also [How to connect small and large grid blocks](https://spaceengineers.wiki.gg/wiki/How_to_connect_small_and_large_grid_blocks "How to connect small and large grid blocks") for related building tricks.

#### Total PCU

To preserve good performance, you can limit the global PCU available in this world. Each block has a performance-impact cost, measured in [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU"). Default is 100,000 PCU.

#### Block Limits

To preserve good performance, this setting limits how many blocks a player can build. If your PC is fast enough, you can build beyond the block limit by disabling this.