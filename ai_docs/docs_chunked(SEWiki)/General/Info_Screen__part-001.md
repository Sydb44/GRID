---
title: "Info Screen"
url: "https://spaceengineers.wiki.gg/wiki/Info_Screen"
category: "General"
wiki_page: "Info Screen"
includes_environment: true
includes_blocks: true
---

# Info Screen - Official Space Engineers Wiki

The **Info** tab in the [Terminal](https://spaceengineers.wiki.gg/wiki/Terminal "Terminal") displays information about grids and the world. The word "[grid](https://spaceengineers.wiki.gg/wiki/Grid "Grid")" refers to large and small spaceships/rovers, and bases and stations equally.

Important: The **Info** screen displays different information depending on

*   whether the engineer is standing,
*   or seated in a grid / interacting with a grid.

If you can't find the info you are looking for, check _whose_ Info tab you are looking at.

[![personal Info tab](https://spaceengineers.wiki.gg/images/thumb/Terminal-personal-info-tab.png/320px-Terminal-personal-info-tab.png?e5cc7f)](https://spaceengineers.wiki.gg/wiki/File:Terminal-personal-info-tab.png)

The engineer's personal Info tab in the Terminal, listing owned blocks and used PCU

## Usage

The Info Screen is where you rename and convert grids, check their [performance impact](https://spaceengineers.wiki.gg/wiki/PCU "PCU"). You can also make the [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD") visualise antenna and sensor ranges, [Automaton waypoints](https://spaceengineers.wiki.gg/wiki/Artificial_Intelligence "Artificial Intelligence"), and center of mass.

The Info screen can answer the following questions:

## How do I name grids?

The default grid names are "Static grid 1", "Large Grid 2", or "Small Grid 3" and so on, each with sequential numbering.

Naming grids properly is important before you save [blueprints](https://spaceengineers.wiki.gg/wiki/Blueprint "Blueprint") so they remain findable in the list. Also when you intend to [remote control](https://spaceengineers.wiki.gg/wiki/Remote_Control "Remote Control") grids, you need to be able to tell them apart to connect to the right one.

Note: When you use [Projectors](https://spaceengineers.wiki.gg/wiki/Projector "Projector") to build, or [merge blocks](https://spaceengineers.wiki.gg/wiki/Merge_Block "Merge Block") to merge and unmerge grids, the new grids will be unnamed and you will have to type it in again.

Troubleshooting: There's a rare issue that you cannot type a new name into the field because it keeps resetting. Check whether something in your world is updating the grid a lot, is another player changing settings or some timer is switching connectors on/off?

## Can grids / players see my Antenna?

You may want to know whether a drone can see your [antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") --whether it is "within your antenna range"-- so you can remote control it. In [Multiplayer](https://spaceengineers.wiki.gg/wiki/Multiplayer "Multiplayer"), other players may be able to see your (or your grid's) antenna and find your location.

Antennas must be set to broadcasting and be powered to have a range.

*   **Show antenna range** -- This setting shows the spherical areas of effect of active antennas on the grid. Each antenna displays its own range sphere in the world for you.

The range spheres can be quite big and hard to spot if seen against the sky or if overlapping. If you don't see anything, try sitting in a cockpit and switch to third-person view.

## Can I see others' antennas?

If there are many distracting antenna signals at a distance, and you want to instead focus on the signals that are close by, decrease these HUD settings.

These settings are about how open you are to perceiving others' [antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") signals, or finding your own parked ships/drones again.

*   **Show distance for friendly antennas** -- Maximum range at which broadcasting friendly antennas are displayed on your [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD")
*   **Show distance for enemy antennas** -- Maximum range at which broadcasting enemy antennas are displayed on your HUD
*   **Show distance for owned antennas** -- Maximum range at which broadcasting own antennas are displayed on your HUD

The game doesn't have an active radar. If the other antennas are not broadcasting, or are only broadcoasting at a very low range, you might still not see them, no matter what you choose here.

## Why does my sensor not trigger?

Seeing the range of a [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") is valuable while configuring it. You want to know exactly whether the sensor is monitoring the intended area, and not getting triggered accidentally from the floor below, or next door through the wall, or by someone crouching one floor above, etc.

*   **Show sensors field range** -- Shows the cuboid area of effect around a sensor. You must at the same time enable **Show on HUD** on the Sensor's Control Panel for this to work.

## What's the flight path of my Automatons?

If you are using the autonomous behaviours of [Automatons](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton"), you will want to review their flight paths as recorded by the [AI Recorder](https://spaceengineers.wiki.gg/wiki/AI_Recorder "AI Recorder") block.

*   **Show AI Functions** -- Makes Automaton flight path and waypoints visible in mid air. Remember to add a (temporary) [Antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") to the drone and set it to broadcast. On the Control Panel for the AI Recorder block, switch on **Show Path on HUD** and **Show Selected Points**!

## What does the Physics Engine think it's doing?

[![pivot versus CoM](https://spaceengineers.wiki.gg/images/thumb/Center-of-mass-versus-pivot.png/320px-Center-of-mass-versus-pivot.png?bc0748)](https://spaceengineers.wiki.gg/wiki/File:Center-of-mass-versus-pivot.png)

When you add blocks to a grid, the pivot point stays on the first block, but the center of mass shifts.

The following view options are valid for all grids, not just the one you are interacting with, until you switch them off or restart the game. The physics markers only appear when you are close (~40m) to the grid, they are sometimes hard to see on large grid ships. Also, the center of mass and pivot markers can be in the same spot, especially if you are looking at one single block.

*   **Show center of mass** -- The calculated center of the grid is used for gyroscope rotation. The marker looks like a red dot with six yellow rays sticking out.  
    See also [Center of Mass](https://spaceengineers.wiki.gg/wiki/Center_of_Mass "Center of Mass").
*   **Show grid pivot** -- The first built block point around which the grid rotates when being projected or pasted. The marker looks like a red dot with three coloured coordinate axes sticking out.  
    See also [Grid Pivot](https://spaceengineers.wiki.gg/wiki/Grid_Pivot "Grid Pivot").
*   **Show gravity range** -- Shows the cuboid/spherical area of effect around a gravity generator. You must enable "Show on [HUD](https://spaceengineers.wiki.gg/wiki/HUD "HUD")" on the Gravity Generator's Control panel for this to work.  
    See also [Gravity](https://spaceengineers.wiki.gg/wiki/Gravity "Gravity").

You don't need an antenna to see these markers.
