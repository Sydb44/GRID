---
title: "Claim NPC Ship"
url: "https://spaceengineers.wiki.gg/wiki/Claim_NPC_Ship"
category: "Creatures"
wiki_page: "Claim NPC Ship"
includes_blocks: true
---

# Claim NPC Ship - Official Space Engineers Wiki

From update v1.204 onwards, [NPC ships](https://spaceengineers.wiki.gg/wiki/Encounters "Encounters") despawn after 2 hours to free up the NPCs' [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") pool. This would have the disadvantage that you could not keep captured ships, so a PCU claiming mechanic was introduced.

Claiming PCU is separate from gaining [ownership](https://spaceengineers.wiki.gg/wiki/Ownership "Ownership")!

## What problem does PCU claiming solve?

NPC ships are owned by [NPC Factions](https://spaceengineers.wiki.gg/wiki/NPC_Factions "NPC Factions") and spawn as [encounters](https://spaceengineers.wiki.gg/wiki/Encounters "Encounters"). To ensure the game maintains performance, the number of ships each NPC or player [faction](https://spaceengineers.wiki.gg/wiki/Faction "Faction") can own is governed by a value called [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU").

Before v1.204, when players captured NPC ships and transferred [ownership](https://spaceengineers.wiki.gg/wiki/Ownership "Ownership") to themselves, the ships' blocks (inadvertently?) remained in the NPCs' [PCU](https://spaceengineers.wiki.gg/wiki/PCU "PCU") pool. This had the disadvantage that, after a few ship captures, the NPCs' PCU pool was exhausted, and no further NPC ships would spawn.

The **Claim NPC Ship** button in the [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") helps keep the NPC ships PCU pool free to keep spawning more encounters by subtracting the PCU from the player's pool instead.

The Claim button does not affect the [ownership](https://spaceengineers.wiki.gg/wiki/Ownership "Ownership") of the functional blocks inside the ship! You still have to [hack](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking") the blocks to be able to use them, to access the ship's [terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal") and inventory, and to keep the ship from despawning.

## Usage

[![](https://spaceengineers.wiki.gg/images/thumb/a/af/Claim-npc-grid.png/320px-Claim-npc-grid.png?466132)](https://spaceengineers.wiki.gg/wiki/File:Claim-npc-grid.png)

To claim a captured ship:

1.  Interact with a [hacked](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking") [terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal") on the NPC ship.
2.  Notice the despawn timer.
3.  Click **Claim NPC Grid**. This transfers the PCU to you.
4.  [Hack](https://spaceengineers.wiki.gg/wiki/Hacking "Hacking") all functional blocks that to gain ownership -- or grind unowned blocks down.

You can see that you have hacked enough blocks when they appear in the terminal in white instead of red.

## When does the Timer start?

While the NPC ship is flying past, or when you are shooting at it, the timer is not running yet. The ship may despawn naturally at the end of its path.

The NPC claim timer starts as soon as non-NPC ownership or authorship is detected on the grid. For instance, the timer starts after you hack (grind down and re-weld) the first block, or when you build a new functional block on the grid.

## Mod interactions

If you are using mods that interfere with or override the default NPC spawns, this Claim game mechanic can be either not available, or it suddenly despawns NPC owned grids retroactively if you didn't hack all blocks.