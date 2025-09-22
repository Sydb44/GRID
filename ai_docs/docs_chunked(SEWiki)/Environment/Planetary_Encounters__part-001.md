---
title: "Category:Planetary Encounters"
url: "https://spaceengineers.wiki.gg/wiki/Planetary_Encounters"
category: "Environment"
wiki_page: "Planetary Encounters"
includes_environment: true
includes_blocks: true
---

# Category:Planetary Encounters - Official Space Engineers Wiki

These planetary exploration [encounters](https://spaceengineers.wiki.gg/wiki/Encounters "Encounters") include derelict ships, outposts, and more. First, edit your game save and open the [World Settings](https://spaceengineers.wiki.gg/wiki/World_Settings "World Settings") and make sure the Planetary Encounters checkbox is enabled.

## Where can I find them?

Encounters attempt to spawn on flat ground near each player every 15-30mins within a 6km radius.

Planetary encounters can spawn on [all vanilla planets and their moons](https://spaceengineers.wiki.gg/wiki/Planets "Planets") (EarthLike, Moon, Mars, Europa, Pertam, Titan, Triton and Alien). For details see below. On the frozen moons Europa and Triton, the same encounters appear but are visually covered in ice. Many encounters (except for the Pirate and Unknown Faction encounters) have extra visual variants for the airless low-g Moon.

Watch carefully, the encounters broadcast messages on the [chat](https://spaceengineers.wiki.gg/wiki/Chat "Chat") channel when they detect players, to indicate when they switch on their defenses, or when you trigger a new phase of the encounter.

Not all encounters broadcast a constant [signal](https://spaceengineers.wiki.gg/wiki/Signal "Signal") on your [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD"), and also their signal range extends only a few kilometres, therefore, do not rely on a signal being the only way to discover them, you need to explore.

## Planetary Bases

Have you explored one of these encounters? Click the red links below to create a new page, and type up your report. If possible please also upload screenshots of your adventure, describe the loot, and mark spoilers.

The following encounters are associated with [NPC Factions](https://spaceengineers.wiki.gg/wiki/NPC_Factions "NPC Factions"). You will lose standing with them and their allies if you destroy their structures. Also, their antennas can potentially spawn drones.

*   Encounter Military Barracks - Military factions
*   [Encounter Vanguard Outpost](https://spaceengineers.wiki.gg/wiki/Encounter_Vanguard_Outpost "Encounter Vanguard Outpost") - Military factions
*   [Encounter Military Watchtower](https://spaceengineers.wiki.gg/wiki/Encounter_Military_Watchtower "Encounter Military Watchtower") - Military factions
*   Encounter Manufacturing Facility - Builder factions
*   [Encounter Supply Post](https://spaceengineers.wiki.gg/wiki/Encounter_Supply_Post "Encounter Supply Post") - Builder factions
*   [Encounter Storage Depot](https://spaceengineers.wiki.gg/wiki/Encounter_Storage_Depot "Encounter Storage Depot") - Builder factions
*   [Encounter Pirate Relay Post](https://spaceengineers.wiki.gg/wiki/Encounter_Pirate_Relay_Post "Encounter Pirate Relay Post") - Pirate factions
*   Encounter Salvage Yard - Pirate factions
*   [Encounter Pirate Stronghold](https://spaceengineers.wiki.gg/wiki/Encounter_Pirate_Stronghold "Encounter Pirate Stronghold") - Pirate factions
*   [Encounter Processing Plant](https://spaceengineers.wiki.gg/wiki/Encounter_Processing_Plant "Encounter Processing Plant") - Miner factions
*   [Encounter Prospecting Station](https://spaceengineers.wiki.gg/wiki/Encounter_Prospecting_Station "Encounter Prospecting Station") - Miner factions
*   [Encounter Ore Processing Facility](https://spaceengineers.wiki.gg/wiki/Encounter_Ore_Processing_Facility "Encounter Ore Processing Facility") - Miner factions
*   [Encounter Field Research Outpost](https://spaceengineers.wiki.gg/wiki/Encounter_Field_Research_Outpost "Encounter Field Research Outpost") - Trader factions
*   [Encounter Shipping Platform](https://spaceengineers.wiki.gg/wiki/Encounter_Shipping_Platform "Encounter Shipping Platform") - Trader factions
*   [Encounter Regional Headquarters](https://spaceengineers.wiki.gg/wiki/Encounter_Regional_Headquarters "Encounter Regional Headquarters") - Trader factions

## Planetary Wrecks

The following [Unknown Faction](https://spaceengineers.wiki.gg/wiki/NPC_Factions#NPC_Factions_in_Lore "NPC Factions") exploration content is marked as a "Distress Signal" on your [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD") and is not owned by any NPC faction. The structures spawn either frozen on ice moons, or rusted on planets with an atmosphere:

*   Encounter Abandoned Rover
*   [Encounter Abandoned Shuttle](https://spaceengineers.wiki.gg/wiki/Encounter_Abandoned_Shuttle "Encounter Abandoned Shuttle")
*   [Encounter Abandoned Explorer](https://spaceengineers.wiki.gg/wiki/Encounter_Abandoned_Explorer "Encounter Abandoned Explorer")
*   [Encounter Abandoned Colony Ship](https://spaceengineers.wiki.gg/wiki/Encounter_Abandoned_Colony_Ship "Encounter Abandoned Colony Ship")
*   Encounter D-2 Hauler Wreck
*   Encounter Trade Runner Wreck
*   Encounter Logistics Post

## Detailed spawning mechanics

Each player will trigger a spawn, but the randomizer first rolls for a random encounter valid _for that particular planet_ (improved in 206), then a random terrain position within that range, which then gets checked for various conditions to allow the spawn to happen or not.

The "players'" position in the context of this system means the position of anything that they're controlling, if they're controlling a ship remotely, then that Remote Control block's position can trigger a spawn.

### Conditions

Conditions that can **prevent** a planetary encounter from spawning:

*   Player position is [6km (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterDesiredSpawnRange "Modding/Reference/Saves/SessionSettings") away from the surface.
*   The shared [NPC PCU pool](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PiratePCU "Modding/Reference/Saves/SessionSettings") was exceeded by too many NPC ships/bases.
*   (Rerollable) The randomly picked encounter for that planet requires a specific voxel material that is not at the randomly picked position.
*   (Rerollable) Other PEs within [10km (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterAreaLockdownRange "Modding/Reference/Saves/SessionSettings") or other static grids within [7km (world setting)](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Saves/SessionSettings#PlanetaryEncounterExistingStructuresRange "Modding/Reference/Saves/SessionSettings") of the randomly picked position (not the player position).
*   The randomly picked encounter's allowed faction types (builder, miner, pirate, etc) are not used by any NPC faction in the world.

The "Rerollable" ones will allow it to try again up to 8 times total for this spawn attempt (with no time delay between attempts).

Because of the above behavior, encounters are **rare** to spawn because they can easily fail one of those for the 8 times it tries.
