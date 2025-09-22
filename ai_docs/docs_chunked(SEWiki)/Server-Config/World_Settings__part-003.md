*   Realistic: The normal speed setting.
*   x0.5: Welding reduced to half speed.
*   x2 / x5: Welding increased by a factor of two/five.

#### View Distance

Larger view distances can cause performance issues depending on how many objects are in the world. Large view distances are also not recommended in worlds with high asteroid density. The performance-friendly recommendation for low-end machines is 5-10 km, whereas 30-50km is only recommended for high-end machines. The default distance is 15 km.

#### Floating Object Limit

This option determines how many items are allowed to float freely in space or lie on the ground. Objects include space ship debris, dropped items like components and ingots, and mined rocks and ores. The host can set the maximum number of floating objects between 16 and 1024. Default is 100.

Warning: Having extremely large number of objects floating freely can slow down the game significantly. If the chosen maximum value is exceeded, the oldest objects (those that have been loose the longest) are automatically deleted from the world. The automatic deletion of debris is colloquially called **garbage collection** or **trash clean-up** and its behaviour can be configured or suspended on the [Admin Screen](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen") in a running game.

#### **Max blocks per player**

The host can limit the maximum number of blocks that each player can use in total in this world to a value between 300 and 100,000. Players get a warning with a remaining-block counter, and if their allocation reaches zero, they are prevented from building additional blocks. Destroyed or grinded blocks are refunded. Enable this option to preserve performance on [multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") servers. By default and in single-player, this limit is not enforced (disabled).

#### **Max Grid Size**

The host can limit the maximum number of blocks that players can use per [grid](https://spaceengineers.wiki.gg/wiki/Grid "Grid") (that is, per ship, rover, station, etc. to a value between 100 and 50,000 blocks. If your players build “too big”, enable this option to preserve performance on [multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer") servers. By default and in single-player, this limit is not enforced (disabled).

### Environment

#### Enable Lightning Damage

Whether atmospheric lightning strikes can damage grids and players. Off by default (which is recommended for beginners). Enable lightning damage if you want an extra challenge on planets with [weather](https://spaceengineers.wiki.gg/wiki/Weather "Weather").

#### Enable Weather

Adds different [atmospheric conditions](https://spaceengineers.wiki.gg/wiki/Weather "Weather") to [planets](https://spaceengineers.wiki.gg/wiki/Planets "Planets") with atmospheres, which may limit visibility, or affect the power effectivity of wind mills and solar panels. Enabled by default.

#### Enable Radiation

Adds environmental [Radiation](https://spaceengineers.wiki.gg/wiki/Radiation "Radiation") hazards to broken reactors and weather. Disabled by default. Used together with Solar Radiation Intensity and Airtightness.

#### Enable sun rotation

In Space Engineers (as opposed to the real world), the sun orbits around the planets to create the appearance of day and night on planets in the [Star System](https://spaceengineers.wiki.gg/wiki/Star_System "Star System"). Sun rotation can be switched on or off. For example, switch it on during normal survival gameplay, and switch it off during creative building or when taking [screenshots](https://spaceengineers.wiki.gg/wiki/Screenshots "Screenshots") or recording video. See also "Day duration".

#### Day duration

If „sun rotation” is enabled, you can choose an in-game day duration between 1 min and 1 day in real-life time. Day length is the same for all planets. Default is 2 hours.

#### Asteroid amount

This option determines the density how many [asteroids](https://spaceengineers.wiki.gg/wiki/Asteroid "Asteroid") are generated in space when the world is created. The asteroid amount option is not available for the Empty World scenario. Because it affects world generation, this option cannot be changed retroactively after loading an existing world.

#### Meteor Activity (was: environment hostility)

This option determines whether or not meteor strikes are enabled and how frequently they occur. Choose from Safe, Normal, Cataclysm, or Armageddon -- see [Meteor](https://spaceengineers.wiki.gg/wiki/Meteor "Meteor") for more details.

#### World Size

By default, the world size is unlimited (realistically up to about 1,000,000,000 km, after which the precision of object positions will become a problem). For challenge scenarios that forces players into a central battlefield, you can choose to limit the world size to a cube with a side length of 10, 20, 50, or 100 km. All objects that leave this area will be deleted from the game, and characters that leave will die.

#### Sound Mode

You can choose between Arcade and Realistic sounds. Arcade sounds are how sound is often depicted in science fiction (audible explosions in space), whereas Realistic sound is more muffled in vacuum and with the helmet closed.

#### Solar Radiation Intensity

Requires Radiation and Airtightness to be enabled. This challenge adds an environmental hazard for being exposed to direct sunlight. Certain planetary atmospheres, roofs, and pressurized closed rooms (including closed cockpits) protect you from solar radiation damage. You can choose to set this to Disabled, Light, Medium, or Heavy.

### Survival

#### Enable Auto-Healing

If enabled, engineers will automatically heal damage in [pressurized](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness") environments at a slow rate. If disabled, they will need [Survival Kits](https://spaceengineers.wiki.gg/wiki/Survival_Kit "Survival Kit"), [Medical Rooms](https://spaceengineers.wiki.gg/wiki/Medical_Room "Medical Room"), or [Medkits](https://spaceengineers.wiki.gg/wiki/Medkit "Medkit") to heal. Enabled by default.
