*   If it falls below 90%, the EC performs the second action, which is ALSO to toggle the lights, and now red is off and green is on.

Trivia: Usually the EC action is to run two separate Timer blocks: One to switch the light on and do something, and one to switch it off and do something else. But we merely want to toggle a light, so we simplify and use only one timer block that toggles both lights. The EC however does not accept the same block action twice, so we cannot set up Timer>Run for both slots. That's why we use Timer>Trigger Now for the second (which also runs the block, the outcome being the same).

## Are there better/further visible lights?

Do you find it hard to distinguish whether the [Interior Lights](https://spaceengineers.wiki.gg/wiki/Interior_Light "Interior Light") are on or off in a lit room?

*   Replace the interior lights with [Text Panels](https://spaceengineers.wiki.gg/wiki/Text_Panel "Text Panel") with a red or green background colour, and toggle them on and off.
*   Or if you have the DLC, replace the interior lights with one red and one green [Light Panel](https://spaceengineers.wiki.gg/wiki/Light_Panel "Light Panel"); they are black when off and show their bright colour when on.
*   Or if you have the DLC, and you want to depict two or more states in one block space, use  [![Icon Block Emotion Controller.png](https://spaceengineers.wiki.gg/images/thumb/Icon_Block_Emotion_Controller.png/21px-Icon_Block_Emotion_Controller.png?f7897f)](https://spaceengineers.wiki.gg/wiki/Emotion_Controller "Emotion Controller") [Emotion Controller](https://spaceengineers.wiki.gg/wiki/Emotion_Controller "Emotion Controller")s.

If you need the warning lights to be visible very far, or even through walls, consider using named [Beacons](https://spaceengineers.wiki.gg/wiki/Beacon "Beacon") instead.

## How to continue from here

You can, of course, build several rows of these monitors, each row with its own lights, detecting a different event: Cargo levels, tank filling, power levels, and so on. Check out what else the [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") can detect!

You'll notice that the Event Controller cannot detect enemies.

*   To detect enemies at long-range, replace the EC in that row with a configured [AI Defensive or Offensive](https://spaceengineers.wiki.gg/wiki/Automaton "Automaton") block.
*   Or as a short-range detector, such as indoors, use a configured [Sensor](https://spaceengineers.wiki.gg/wiki/Sensor "Sensor") block near the monitored area instead.

How can you ensure that a specific monitored cargo container contains all ammo, or all steel plates, or all ice, etc., so you can know whether you are running out? Use [Conveyor Sorters](https://spaceengineers.wiki.gg/wiki/Conveyor_Sorter "Conveyor Sorter")!

You could also set up three coloured lights (high, medium, low), but it's a bit cumbersome. One event controller can only watch one threshold, and you need several to monitor a min/max range. Also you will need three Timers to toggle one light on and the other two lights off.

## Workshop

Download [Arstraea's ONYX - Computer block](https://steamcommunity.com/sharedfiles/filedetails/?id=882033944) from the Steam Workshop to study a variant of this approach. This example houses Sensors, Programmable Blocks, Lights, Sound blocks, Buttons, and Timers. To attach to the large-grid ship, it uses Connectors instead of Rotors.