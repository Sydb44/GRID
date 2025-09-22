*   If you jump the maximum distance, it discharges Drive X and all other Drives that are switched on and fully charged.
*   If you jump less than maximum distance, it discharges one Drive after the other (instead of discharging all of them partially).

The "Jump" action is not available for [grouped](https://spaceengineers.wiki.gg/wiki/Groups "Groups") Jump Drives in the [Toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar "Toolbar"). This is because each Jump Drive could be set to a different target or different distance and it wouldn't be clear which you mean. Additionally you cannot automate jumps. The "Jump" action can only be activated by a pilot, it cannot be invoked by a timer block, button panel or similar.

  
How to configure the [toolbar](https://spaceengineers.wiki.gg/wiki/Toolbar_Configuration "Toolbar Configuration"):

*   Add each _configured_ Drive's **Jump** action to the toolbar individually.
*   Add each Drive's **on/off** action to the toolbar.
*   Add each Drive's **Recharge on/off** action to the toolbar.

Remember, you have nine toolbars.

### What happens to passengers and docked ships?

*   Players sitting in cockpits or seats, holding on to ladders, or resting in beds or cryochambers, will teleport with the jumping ship.
*   Free floating or free standing engineers --or boarders!-- will be left behind.
*   Docked ships and vehicles that use Connectors or magnetic Landing Gear count into the total mass and will jump with the mothership.
*   Loose grids and floating components are left behind.

### What are the limits?

If you receive a gravity warning, you must either travel further away from a planet/moon, or (if you are in zero g) select a shorter jump distance before trying again.

*   Jump Drives cannot jump if the line of sight is blocked by a planetary body or asteroid.
*   Jump Drives cannot jump in or out of natural gravity wells.
    *   There have been rare occurrences of Jump Drives jumping into the middle of hollow asteroids.
*   If the target GPS or beacon are closer than 5 km, the jump drive will show a warning dialog and will not engage.
*   If you attempt to jump with only partial charge, the jump drive will show a warning dialog and will not engage.

If the total mass of your ship including cargo exceeds 1'250'000 kg, your effective maximum jump distance will decrease.

### How to postpone or cancel a jump?

During the countdown, activate the "Jump" action again. The same dialog will appear:

*   Either click "No" to abort.
*   Or click "Yes" to restart the 10 second countdown.

Restarting the countdown may buy a dawdling team member enough time to get seated, in which case you might not need to abort.

### Best Practices

Example: Your max jump range is 2000km, and you want to jump to a friendly station 2500km away. You first make a short, partial jump of 500km, recharge quickly en route, then jump 2000km, dock, and let it fully recharge at the allied station.

If you had made the maximum jump first, you would need to wait longest in the middle of the trip, where you could be stuck with no way to quickly escape pirates. In general, if you travel further than maximum jump range, make the shorter jump first.

Especially when jumping into unknown or dangerous territory, several short jumps are better than one large one. The capacitor recovers faster from a short jump, and any short jump can get you out of immediate danger.

If you have several, better keep one charged Jump Drive as a backup. Switch this emergency drive off _before_ jumping using the others. Don't get caught by enemies en route with a discharged Jump Drive only because you were rushing.

## Power

Maximum stored power inside a jump drive is **3 MWh** with a maximum charge rate **32 MW**, though charging is only 80% efficient.

|     |     |     |     |
| --- | --- | --- | --- |
| Max Input | Max Stored Power | Input Efficiency | Charge Time |
| 32 MW | 3 MWh | 80% | 7 minutes |

Jump Drives have priority when charging, which means they will consume the [power](https://spaceengineers.wiki.gg/wiki/Power "Power") first before batteries, thrusters, and  [![Icon Block Gyroscope.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Gyroscope.png/21px-Icon_Block_Gyroscope.png?c8eb45)](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") [Gyroscopes](https://spaceengineers.wiki.gg/wiki/Gyroscope "Gyroscope") will receive power. All Jump Drives present will proceed to hog power until fully charged. If the power drain is detrimental to essential ship function, use the Jump Drive's "Recharge on/off" toggle to temporarily pause charging.

Jump Drives charge at only 80% power efficiency, so despite requiring 3 MWh of stored power to jump, they actually require a total of 3.75 MWh of energy to fully charge that stored energy.

### Jump Drive Status Indicators

The indicator status light colors display information about the Jump Drive's charging status:

| Indicator | Charge Level | Mode | Description |
| --- | --- | --- | --- |
| [![Solar off.svg](https://spaceengineers.wiki.gg/images/Solar_off.svg?e30b19)](https://spaceengineers.wiki.gg/wiki/File:Solar_off.svg) | NA  | Off | **Red indicators**: The Jump Drive is turned off or damaged. |
| [![Indicator yellow 1.svg](https://spaceengineers.wiki.gg/images/Indicator_yellow_1.svg?c460a9)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_1.svg) | 0-24% | Charging | **Yellow indicator:** 1 yellow lights - The Jump Drive is charging and is charged between 0% to 24%. |
| [![Indicator yellow 2.svg](https://spaceengineers.wiki.gg/images/Indicator_yellow_2.svg?a8f00a)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_2.svg) | 25-49% | Charging | **Yellow indicator:** 2 yellow lights - The Jump Drive is charging and is charged between 25% to 49%. |
| [![Indicator yellow 3.svg](https://spaceengineers.wiki.gg/images/Indicator_yellow_3.svg?7eb167)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_3.svg) | 50-74% | Charging | **Yellow indicator:** 3 yellow lights - The Jump Drive is charging and is charged between 50% to 74%. |
| [![Indicator yellow 4.svg](https://spaceengineers.wiki.gg/images/Indicator_yellow_4.svg?936f7b)](https://spaceengineers.wiki.gg/wiki/File:Indicator_yellow_4.svg) | 75-99% | Charging | **Yellow indicator:** 4 yellow lights - The Jump Drive is charging and is charged between 75% to 99%. |
| [![Solar power indicator 100.svg](https://spaceengineers.wiki.gg/images/Solar_power_indicator_100.svg?d8898c)](https://spaceengineers.wiki.gg/wiki/File:Solar_power_indicator_100.svg) | 100% | Ready | **Green indicator:** 4 green lights - The Jump Drive is fully charged and ready to jump. |

When the drive is not yet at 100% charge, the maximum jump distance displayed in the UI will by only 5km (though it still will not be able to jump yet). If you cannot select a jump distance of more than 5km, that is also a hint that the drive is not charged yet.
