---
title: "How to set up the toolbar"
url: "https://spaceengineers.wiki.gg/wiki/How_to_set_up_the_toolbar"
category: "Equipment"
wiki_page: "How to set up the toolbar"
includes_blocks: true
---

# How to set up the toolbar

Here some examples how to set up the [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar") for various situations. Remember that you have nine toolbars [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[1 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings") to [CTRL key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings")+[9 key](https://spaceengineers.wiki.gg/wiki/Key_Bindings "Key Bindings"). On stations and larger ships with interiors, you can also assign certain cockpit actions to [Button Panels](https://spaceengineers.wiki.gg/wiki/Button_Panel "Button Panel") for style.

Tip: You will need to know how to [group blocks](https://spaceengineers.wiki.gg/wiki/Groups "Groups") and how to use [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block") to trigger coordinated actions (such as "white lights off, red lights on, sound block play" during an alert).

From the suggestions below, just pick the example lines that fit your situation, not all grids are built the same and not everything applies to everyone.

## For a rover

*   Group of Batteries
    *   **batteries** group > Recharge On/Off
    *   **batteries** group > Discharge On/Off
*   Braking
    *   **Cockpit** > Handbrake on/off
*   Docking and unloading:
    *   **Connector** > Lock/Unlock

*   High power for uphill driving, lower power for flat terrain:
    *   **Wheel suspensions** group > Increase Power
    *   **Wheel suspensions** group > Decrease Power
*   Low strength when unloaded, high strength when full of cargo:
    *   **Wheel suspensions** group > Increase Strength
    *   **Wheel suspensions** group > Decrease Strength
*   Low offset on uneven terrain, high offset for speeding on flat ground:
    *   **Wheel suspensions** group > Increase Height Offset
    *   **Wheel suspensions** group > Decrease Height Offset
*   High Friction for straight hill driving, low for drifting and quick turning:
    *   **Wheel suspensions** group > Increase Friction
    *   **Wheel suspensions** group > Decrease Friction
*   Lower the limit on uneven terrain, increase it for racing.
    *   **Wheel suspensions** group > Increase Speed Limit
    *   **Wheel suspensions** group > Decrease Speed Limit
*   Re-add a broken-off wheel while driving:
    *   **Wheel suspensions** group > Add Wheel

*   Stabilization gyroscope: Set the "third" gyroscope to zero RPM around all 3 axes. Pulse it on/off to prevent tipping.
    *   **Gyroscope** > Override on/off
*   Roll after flipping: Set the "third" gyroscope to a medium RPM value along the Roll axis for a few secobds. Keep it switched off while driving.
    *   **Gyroscope** > Override on/off

*   Undercar lighting:
    *   **Interior lights** group > Toggle on/off
*   Foldable door or ramp
    *   **Hinge** > Revert

## For a shuttle

*   Power
    *   **Batteries** group > Discharge On/Off
    *   **Batteries** group > Recharge On/Off
*   For flying in general
    *   **hydrogen tanks** group > Stockpile on/off
    *   **hydrogen thrusters** group > Toggle on/off
*   For planetary lift off or landing:
    *   downward facing **hydrogen thrusters** group > Override on/off
    *   downward facing **hydrogen thrusters** group > Increase Override
    *   downward facing **hydrogen thrusters** group > Decrease Override
    *   **Parachute Hatches** group > Open / Close
    *   **Parachute Hatches** group > Auto on/off
*   Docking
    *   **Landing Gears** group > Lock/Unlock
    *   **Connector** > Lock/Unlock
*   Misc
    *   **O2/H2 generator** > Toggle on/off
*   Orientation
    *   **Antenna** > on/off
    *   **Beacon** > on/off

## For an atmo ship

*   Power
    *   **Batteries** group > Discharge On/Off
    *   **Batteries** group > Recharge On/Off
*   For flying in general
    *   **atmosphere thrusters** group > Toggle on/off
*   For planetary forward flying:
    *   forward facing **atmosphere thrusters** group > On/Off
    *   backwards facing **atmosphere thrusters** group > Thruster Override On/Off
    *   forward facing **atmosphere thrusters** group > Thruster Override increase
    *   forward facing **atmosphere thrusters** group > Thruster Override decrease
*   For emergencies:
    *   **Parachute Hatches** group > Open / Close
    *   **Parachute Hatches** group > Auto on/off
*   Docking
    *   **Landing Gears** group > Lock/Unlock
    *   **Connector** > Lock/Unlock

Tip: On long atmospheric flights, you need the [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers") to not fall out of the sky, but they will fight your forward acceleration and keep engaging your braking thrusters, which wastes power. Keep [Inertial Dampers](https://spaceengineers.wiki.gg/wiki/Inertial_Dampers "Inertial Dampers") on, but switch the forward facing (=braking) thruster group off temporarily while you use the back facing thrusters to maintain your speed. When you need to manoeuvre, or slow down, or brake, or dock, obviously switch all thrusters back on.

## For an Ion spaceship

*   Power
    *   **Batteries** group > Discharge On/Off
    *   **Batteries** group > Recharge On/Off
*   Jumping
    *   **Jump Drive** > Jump
*   Docking
    *   **Landing Gears** group > Lock/Unlock
    *   **Connector** > Lock/Unlock
*   Orientation
    *   **Camera** > View
    *   **Antenna** > on/off
    *   **Beacon** > on/off
*   Life Support
    *   **doors** group > Close
    *   **Air vents** group > Depressurize on/off
    *   **Gravity Generator** > on/off
    *   emergency exits **doors** group > Show on HUD

## For a space station

*   Life Support
    *   red-alert/normal lights toggle **Timer** > start
    *   **doors** group > Close
    *   individual **Air vents** > Depressurize on/off
    *   **Gravity Generator** > on/off
    *   emergency exits **doors** group > Show on HUD
*   Security
    *   individual **Cameras** > View
    *   **Antenna** > on/off
    *   **Beacon** > on/off
    *   **AI Defense** > on/off
    *   **turrets** group > on/off
    *   **turrets** group > target neutrals on/off etc.
*   Facilities
    *   **Refineries** group >on/off
    *   **Assemblers** group > on/off
    *   **Conveyor Sorter**: on/off
*   Drone launch sequences: (custom)
