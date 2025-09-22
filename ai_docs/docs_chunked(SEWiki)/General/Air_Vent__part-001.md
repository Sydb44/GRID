---
title: "Air Vent"
url: "https://spaceengineers.wiki.gg/wiki/Air_Vent"
category: "General"
wiki_page: "Air Vent"
includes_environment: true
includes_blocks: true
---

# Air Vent - Official Space Engineers Wiki

| Air Vent |     |
| --- | --- |
| [![Icon Block Air Vent.png](https://spaceengineers.wiki.gg/images/7/7a/Icon_Block_Air_Vent.png?2f99e7)](https://spaceengineers.wiki.gg/wiki/File:Icon_Block_Air_Vent.png) |     |
| * * * |     |
| **Function:** | The Airvent can fill a sealed room with oxygen or extract oxygen fr... |
| **DLC?** | Vanilla |
| * * * |     |
| **Fits small grid** |     |
| Mass: | 189.0 kg |
| Hitpoints: | 685 |
| PCU: | 10  |
| Size: | 1x1x1 |
| Time to Build: | 10 sec |
| * * * |     |
| **Fits large grid** |     |
| Mass: | 1001.0 kg |
| Hitpoints: | 4005 |
| PCU: | 10  |
| Size: | 1x1x1 |
| Time to Build: | 20 sec |
| * * * |     |
| _Data Controls:_ | \[[purge](https://spaceengineers.wiki.gg/wiki/Air_Vent?action=purge)\] ([?](https://spaceengineers.wiki.gg/wiki/Template:Info_Block))) |
|     |     |

You use the Air Vent block to fill an airtight room with [oxygen](https://spaceengineers.wiki.gg/wiki/Oxygen "Oxygen"), or to empty a room of oxygen to store it safely in tanks.

The Air Vent is the block that is the main driver of the [life support](https://spaceengineers.wiki.gg/wiki/Life_Support "Life Support") game mechanic that was released in the 01.074 update. For a definition of airtightness, see [Airtightness](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness").

For a fully airtight block variant, see also [Air Vent Full](https://spaceengineers.wiki.gg/wiki/Air_Vent_Full "Air Vent Full"). The [Air Vent Fan](https://spaceengineers.wiki.gg/wiki/Air_Vent_Fan "Air Vent Fan") is a variant from the purchasable [Automatons Pack](https://spaceengineers.wiki.gg/wiki/Automatons_Pack "Automatons Pack") DLC; it has the same functionality but has an animated spinning fan.

## Usage

The block has two modes:

*   **Pressurize** means fillig a room with breatheable air from e.g. a tank
*   **Depressurize** means removing oxygen from the room and pushing it into tanks

### How to fill a room with air

1.  Build an [airtight](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness") room.
2.  Connect the conveyor system to [Oxygen Tanks](https://spaceengineers.wiki.gg/wiki/Oxygen_Tank "Oxygen Tank"), or [Oxygen Farms](https://spaceengineers.wiki.gg/wiki/Oxygen_Farm "Oxygen Farm"), or an [O2 H2 Generator](https://spaceengineers.wiki.gg/wiki/O2_H2_Generator "O2 H2 Generator"), depending on your use case.
3.  Open the [Control Panel](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") and disable **Stockpile** on the oxygen tanks (if applicable).
4.  Build the Air Vent so the vent slats face into an airtight room. It can be in the wall, floor, or ceiling.
5.  Connect the Air Vent to the conveyor system.
6.  Open the [Control Panel](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen") and enable **Pressurize**.

The Air Vent will slowly fill the airtight room in front of the slats with oxygen which provides life support for the engineers within, so they can open their helmets.

### How to fill oxygen tanks

If you are low on ice or oxygen and cannot afford to waste it, use **depressurization** to make an air vent suck the air out of one airtight room, either to fill an empty tank, or to use the air to pressurize another room or airlock.

If you are on a planet with an oxygen-rich atmosphere, here's a valuable survival tip: Build an Air Vent on an _outside_ conveyor port and set it to **depressurise**.

*   An outside Air Vent can suck in oxygen from the atmosphere into a connected [Oxygen Tank](https://spaceengineers.wiki.gg/wiki/Oxygen_Tank "Oxygen Tank") -- you "depressurize the planet"[\[1\]](#cite_note-1), so to speak.
*   An outside Air Vent can also provide oxygen to a player seated in a closed [cockpit](https://spaceengineers.wiki.gg/wiki/Cockpit "Cockpit") on a low-oxygen planet.

This knowledge can save you in an emergency if you run out of oxygen bottles, are out of ice, or your O2/H2 Generator breaks down.

You know the Air Vent is in the process of depressurizing when its status lights are blue. If it doesn’t depressurize, check whether the tanks are not already full.

### How to tell if a room is pressurized

Air Vents have four status lights that display (de)pressurization progress and status.

If the Air Vent lights are...

*   **red**, the vent is switched off or has no power -- switch it on before looking for leaks.
*   **yellow**, the room is not airtight, e.g. the doors are open or it's an outside vent for a cockpit.  
    (Note that, if you are in atmosphere, the room still contains oxygen, despite not being airtight!)
*   **blue**, the room is _de_pressurizing. The room is airtight and the vent is sucking the oxygen _out of the room_ into tanks.
*   **green** and the engineer's HUD does not say “Oxygen:High and Temperature:Warm”, the room in the process of being pressurized. Wait a minute and check again.
*   All **green** and the engineer's HUD says “Oxygen:High and Temperature:Warm” in green, the room is airtight and pressurized.

### How to build an automatic airlock

You set up actions that depend on a room being pressurised inside an Air Vent block, not in an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller").

1.  Open the Air Vent's [Control Panel Screen](https://spaceengineers.wiki.gg/wiki/Control_Panel_Screen "Control Panel Screen").
2.  Click **Set up Actions**. You'll see two action slots:
    *   The first action is triggered once, when the room is full of oxygen.
    *   The second action is triggered once, when the room has no more oxygen in it.

"No oxygen" means either that the room is no longer airtight because a door has been opened or a wall block was destroyed; or that the room is still airtight but active depressurization has just completed.

Typical actions to set up with this button are air lock related. An air lock cycle may require opening and closing doors combined with audio-visual alerts, and so on. To start a whole series of air lock actions, build several [Timer Blocks](https://spaceengineers.wiki.gg/wiki/Timer_Block "Timer Block"), one that pressurises the room and closes doors, and one that depressurises the room and opens the doors. And make the action slots start the Timers.

For details, see [airtightness](https://spaceengineers.wiki.gg/wiki/Airtightness "Airtightness").
