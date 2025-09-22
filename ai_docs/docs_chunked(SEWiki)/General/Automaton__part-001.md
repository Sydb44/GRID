---
title: "Automaton"
url: "https://spaceengineers.wiki.gg/wiki/Automaton"
category: "General"
wiki_page: "Automaton"
includes_blocks: true
---

# Automaton - Official Space Engineers Wiki

Automaton is 2023's major PvE update focused on automated, autonomous, and animated drones that can be your allies or enemies. It brought several new blocks, mainly [AI Offensive](https://spaceengineers.wiki.gg/wiki/AI_Offensive "AI Offensive"), [AI Defensive](https://spaceengineers.wiki.gg/wiki/AI_Defensive "AI Defensive"), [AI Recorder](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder"), [AI Basic](https://spaceengineers.wiki.gg/wiki/AI_Basic "AI Basic"), [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight").

![](https://i.ytimg.com/vi/SqZrD9tmH_E/hqdefault.jpg)

Load video

![](https://i.ytimg.com/vi/C5RFVapH-gI/hqdefault.jpg)

Load video

## Requirements

If [Progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is on, build a basic Assembler and some lighting block first to unlock AI ([artificially intelligent](https://spaceengineers.wiki.gg/wiki/Artificial_Intelligence "Artificial Intelligence")) blocks.

The drone that uses the AI blocks must have thrust in all six directions.

## Usage

[![](https://spaceengineers.wiki.gg/images/thumb/f/fa/Skynet_drone_wants_to_know_your_position.png/320px-Skynet_drone_wants_to_know_your_position.png?554120)](https://spaceengineers.wiki.gg/wiki/File:Skynet_drone_wants_to_know_your_position.png)

Automatons can be auto-piloted drones that solve simple tasks autonomously.

First, build purpose-designed flying drones that can handle jobs such as transporting cargo, attack/defense, refuelling, and so on -- then, add Automaton blocks to them for various autonomous navigational behaviours. Automatons can follow a player or ship, find a path to a Beacon or GPS point, follow a precise recorded path, approach into shooting range and then dodge out again, and so on.

Tip: Use Automaton blocks together with [Sensors](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") and [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") (EC) to give the drone "senses". Sensors can react to players, voxels, and grids in close vicinity. ECs detect changes in blocks inside the drone and react by switching to the AI Task that you have predefined for that situation. For example, if an EC detects lack of power or damage to its weapon blocks, then switch from AI Offensive (attack behaviour) to AI Defensive (retreating), and so on.

## AI Block Types

There are three types of AI Blocks[\[1\]](#cite_note-1):

*   **AI Move**: Follows waypoints provided by other AI blocks. Controls gyroscopes and thrusters of a drone ship.
*   **AI Combat**: Provides waypoints to AI Move blocks in combat situations. Becomes active while it detects an enemy within a 2500m radius. Controls [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons").
*   **AI Task**: Provides waypoints to AI Move blocks in non-combat situations. Becomes active while there is no enemy within a 2500m radius.

You can place several AI blocks with different settings on the same drone, but only _one block of a type_ can be active at the same time. Enabling one AI block switches off the others of the same type. That is, only one Move block, plus either one Combat block or one Task Block, are running at the same time.

[![AI behaviour diagram](https://spaceengineers.wiki.gg/images/thumb/c/cb/Ai-block-types-mutially-exclusive.jpg/400px-Ai-block-types-mutially-exclusive.jpg?c94e8f)](https://spaceengineers.wiki.gg/wiki/File:Ai-block-types-mutially-exclusive.jpg)

In range of an enemy, AI behaviour switches from Task to Combat; out of range, it switches back to Task.

## AI Blocks

The specialised AI Blocks[\[2\]](#cite_note-2) give your grids a variety of smart drone behaviours, similar to the standard [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot"). It's important to remember that these blocks work together: Task and Combat blocks _calculate_ paths, and Move blocks _navigate_ along the provided paths.

|     |     |     |     |     |
| --- | --- | --- | --- | --- |AI Blocks
| Type: Move | Type: Task |     | Type: Combat |     |
| [AI Flight](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight") | [AI Basic](https://spaceengineers.wiki.gg/wiki/AI_Basic "AI Basic") | [AI Recorder](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder") | [AI Defensive](https://spaceengineers.wiki.gg/wiki/AI_Defensive "AI Defensive") | [AI Offensive](https://spaceengineers.wiki.gg/wiki/AI_Offensive "AI Offensive") |
| Designed for autonomous flight in both space and atmosphere. The AI Flight block enables complex navigation behaviors in-flight as well as detailed control of how your grid will move. | Calculates paths for Move type blocks to either follow the player, or to find its way to a given “Home” destination, or to patrol along GPS waypoints (Autopilot). | Records a human pilots's flight path and can replay this fixed path, including toolbar actions, as input for a Move type block. | Allows for the easy automation of complex defensive behaviours and lets you choose how to identify a threat, when to flee combat, and what location to fall back to. | Performs offensive combat tasks including target identification, targeting priority, and autonomous execution of complex attack flight patterns. |

## Best Practices

[![AI Controller blocks](https://spaceengineers.wiki.gg/images/thumb/6/6c/GridAIControllerBlocks.jpg/320px-GridAIControllerBlocks.jpg?8f2992)](https://spaceengineers.wiki.gg/wiki/File:GridAIControllerBlocks.jpg)

All AI Controller blocks visible on the back of a saucer-shaped flying drone

Tip: Small-grid drones are hard to spot in the wild. If you want your drone to be better visible, add an [Exhaust Pipe](https://spaceengineers.wiki.gg/wiki/Exhaust_Pipe "Exhaust Pipe") block (DLC)!

### How to give quick commands

Add an external button to the drone that toggles its AI Behaviour on/off, or sends it home to its connector, so you can quickly "catch" it again.

If the drone has an antenna and is within your antenna range, use the [Remote Access Screen](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") to change its behaviours through the control panel or to call it back in a pinch.
