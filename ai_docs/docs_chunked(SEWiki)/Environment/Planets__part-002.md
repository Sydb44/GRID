
| Name | Distance | Diameter | Gravity | GPS |
| --- | --- | --- | --- | --- |
| EarthLike | 0.86m | 120.00 | 1.0 g | GPS:EarthLike:0.50:0.50:0.50: |
| Moon | 178.26km | 19.00 | 0.25 g | GPS:Moon:16384.50:136384.50:-113615.50: |
| Mars | 1934.09km | 120.00 | 0.9 g | GPS:Mars:1031072.50:131072.50:1631072.50: |
| Europa | 1858.15km | 19.00 | 0.25g | GPS:Europa:916384.50:16384.50:1616384.50: |
| Triton | 2478.13km | 80.00 | 1.0 g | GPS:Triton:-284463.50:-2434463.50:365536.50: |
| Pertam | 4040.87km | 60.00 | 1.2 g | GPS:Pertam:-3967231.50:-32231.50:-767231.50: |
| Alien | 5734.07km | 120.00 | 1.1 g | GPS:Alien:131072.50:131072.50:5731072.50: |
| Titan | 5800.92km | 19.00 | 0.25 g | GPS:Titan:36384.50:226384.50:5796384.50: |

**Tip:** You can copy the entire table and use "New from clipboard" in the game's GPS window, then double-click each one to mark it non-temporary.

### Distance between Planets and Moons

|     |     |     |     |     |     |
| --- | --- | --- | --- | --- | --- |Distance between planets
|     | EarthLike | Mars | Triton | Pertam | Alien |
| EarthLike | \-  | 1934.08km | 2478.13km | 4040.86km | 5734.06km |
| Mars | 1934.08km | \-  | 3148.68km | 5546.31km | 4197.61km |
| Triton | 2478.13km | 3148.68km | \-  | 4540.55km | 5961.84km |
| Pertam | 4040.86km | 5546.31km | 4540.55km | \-  | 7684.44km |
| Alien | 5734.06km | 4197.61km | 5961.84km | 7684.44km | \-  |

|     |     |
| --- | --- |Distance between planet and moon
| EarthLike-Moon | 178.26km |
| Mars-Europa | 162.85km |
| Alien-Titan | 149.38km |

## How to customise your star system

*   [How to Spawn Planets and Moons Manually](https://spaceengineers.wiki.gg/wiki/How_to_Spawn_Planets_and_Moons_Manually "How to Spawn Planets and Moons Manually")
*   [How to Draw a Star System Map](https://spaceengineers.wiki.gg/wiki/How_to_Draw_a_Star_System_Map "How to Draw a Star System Map")
*   [How to move planets](https://spaceengineers.wiki.gg/wiki/How_to_move_planets "How to move planets")

## Planets’ Game Mechanics

In real life, a planet is a round celestial body that orbits a star on a cleared path. A moon is a natural satellite, a celestial body that orbits a larger body, possibly together with other moons or rings. Asteroids are irregularly shaped small objects that orbit a star, typically in clusters.

In game, [asteroids](https://spaceengineers.wiki.gg/wiki/Asteroid "Asteroid"), moons, and planets are technically exactly the same objects: _Voxels_ arranged in different size and shape.

*   Planets, moons, and asteroids are completely immobile and never actually move along any orbits, no matter how much force or gravity is applied.
*   Planets, moons, and asteroids have in common that they are fully destructible voxels with [Ore](https://spaceengineers.wiki.gg/wiki/Ore "Ore") deposits on them.
*   Planets are 60 to 120 km in diameter.
*   Moons are simply smaller planets, only 19km in diameter, and possess only weak [gravitational fields](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity") of 0.25 g.
*   Asteroids in game are again much smaller than moons and planets. Asteroids have no perceivable gravity.

## Planetary Surface Generation

While their surfaces appear randomly generated, they're in fact pre-loaded voxel models. When you start a [Sandbox Game](https://spaceengineers.wiki.gg/wiki/Sandbox_Game "Sandbox Game"), there is no procedural generation for Planets or Moons, they are always the same. That means you can copy and paste valid GPS locations across (unmodded) games.

Each planet type will spawn the appropriate environment models and surface textures associated with its template. The same properties are applied even when a planet is spawned in manually by the player using the [Spawn Menu](https://spaceengineers.wiki.gg/wiki/Spawn_Menu "Spawn Menu") ([SHIFT key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[F10 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")) in [Creative Mode](https://spaceengineers.wiki.gg/wiki/Creative_Mode "Creative Mode").

When a player in creative mode increases the size of a manually spawned Planet, the game simply stretches the planetary models to accommodate for the new size. The textures and vegetation distribution adjust to the new size to look natural, only the surface model is stretched.

Ores on planets and moons are easier to find, because there are more deposits and several are always clustered together within 150m below the surface. Asteroids, in contrast, contain larger deposits, but they are further apart and spread out over a larger 3D volume of space and many asteroid contain only stone.

*   [Add more planets from the Steam Workshop](https://steamcommunity.com/workshop/browse/?appid=244850&searchtext=&childpublishedfileid=0&browsesort=textsearch&section=readytouseitems&requiredtags%5B%5D=Planet&created_date_range_filter_start=0&created_date_range_filter_end=0&updated_date_range_filter_start=0&updated_date_range_filter_end=0)
*   [Add more planets from Mod.io](https://spaceengineers.mod.io/?filter=t&tag%5B%5D=Planet)
*   Modding guide: [How to create your own planet](https://spaceengineers.wiki.gg/wiki/How_to_create_your_own_planet "How to create your own planet"). The spawn menu also contains a [SystemTestMap](https://spaceengineers.wiki.gg/wiki/SystemTestMap "SystemTestMap").