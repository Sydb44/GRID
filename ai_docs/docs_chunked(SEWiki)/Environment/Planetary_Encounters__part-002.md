### Conditions

Conditions that can **prevent** a planetary encounter from spawning:

*   Player position is [6km (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterDesiredSpawnRange "Modding/Reference/Saves/SessionSettings") away from the surface.
*   The shared [NPC PCU pool](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PiratePCU "Modding/Reference/Saves/SessionSettings") was exceeded by too many NPC ships/bases.
*   (Rerollable) The randomly picked encounter for that planet requires a specific voxel material that is not at the randomly picked position.
*   (Rerollable) Other PEs within [10km (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterAreaLockdownRange "Modding/Reference/Saves/SessionSettings") or other static grids within [7km (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterExistingStructuresRange "Modding/Reference/Saves/SessionSettings") of the randomly picked position (not the player position).
*   The randomly picked encounter's allowed faction types (builder, miner, pirate, etc) are not used by any NPC faction in the world.

The "Rerollable" ones will allow it to try again up to 8 times total for this spawn attempt (with no time delay between attempts).

Because of the above behavior, encounters are **rare** to spawn because they can easily fail one of those for the 8 times it tries.

### Despawn Mechanics

If a planetary encounter gets damaged or gets [claimed](https://spaceengineers.wiki.gg/wiki/Claim_NPC_Ship "Claim NPC Ship"), it stops being tracked by the planetary encounters system, meaning it doesn't get despawned by the below rules, but unclaimed ones still get despawned after the claim timer expires.

For tracked planetary encounters, if no player is within [20km (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterPresenceRange "Modding/Reference/Saves/SessionSettings"), then its grids get deleted and a [2 hours (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterDespawnTimeout "Modding/Reference/Saves/SessionSettings") countdown timer is started. If any player comes within the 20km range then the encounter grids are respawned and the countdown timer is reset to 2 hours again.

### Possible spawn locations

There are 21-27 different PEs that can spawn on vanilla planets and moons, the largest variety (27) spawns on the Alien planet. Only 13 different PEs are available for the Moon.

Voxel Material restrictions: you'll find more PEs on Soil, Sand, and Snow/Ice; fewer PE variants spawn on grass (including alien grass types); and practically none on the rest of voxel materials.

Modded planets will **not** get most of the planetary encounters, with the exception of:

*   Two encounters that spawn on any planet, however, they still have voxel material restrictions (last two in SpawnGroups\_PlanetaryEncounters.sbc).
*   Planets that contain the name of one of the vanilla planets, for example `BarrenMars3`, `SomePlanetMoon` or `EarthLikely`, and similar.
    *   However the planets still need to have the relevant voxel materials to be allowed to spawn in the first place, with the exception of a single encounter that has no voxel restrictions but spawns only on the 3 vanilla moons (3rd from last in SpawnGroups\_PlanetaryEncounters.sbc).

## Troubleshooting

Here are some general troubleshooting steps from Keen Support[\[1\]](#cite_note-1) for addressing issues with Planetary Encounters (PEs) that may prevent them from appearing:

*   Explore the surrounding area – PEs do not spawn near your base or other existing stations. Travel around, as the default spawn range is about 6 km from the player and up to 10 km from static grids. Also, if you're too high above the planet's surface, encounters won’t spawn. If you want a new PE, you can delete an existing one to allow a new one to spawn nearby.

*   Reduce the number of NPC factions – Doing so will result in fewer Economy stations being generated, which can help reduce restrictions on the minimum distance required from other static grids. This may require use of the [Admin Screen](https://spaceengineers.wiki.gg/wiki/Admin_Screen "Admin Screen") and editing the save file.

*   Check for [NPC factions](https://spaceengineers.wiki.gg/wiki/NPC_Factions "NPC Factions") – PEs will not spawn if the world lacks the required factions. Ensure that the world includes factions from categories like miners, traders, builders, military, and pirates. By default, worlds should include factions from each of these categories, if not, it's maybe an old save with all slots taken by old factions.

## Spoilers

**Spoiler warning!**  
This article or section contains details about the game which players may be intended to discover on their own!

Reveal spoilers

Rumour has it that on the Alien planet, your suit HUD can detect a rare encounter that is marked as “Strange Signal”. Have you explored it? Then click the red link and write about it here!

## References

1.  [↑](#cite_ref-1 "Jump up") [https://support.keenswh.com/spaceengineers/pc/topic/44312-planetary-installations-not-spawning-for-different-reasons](https://support.keenswh.com/spaceengineers/pc/topic/44312-planetary-installations-not-spawning-for-different-reasons)