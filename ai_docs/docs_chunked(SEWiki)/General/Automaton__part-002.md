## Best Practices

[![AI Controller blocks](https://spaceengineers.wiki.gg/images/thumb/6/6c/GridAIControllerBlocks.jpg/320px-GridAIControllerBlocks.jpg?8f2992)](https://spaceengineers.wiki.gg/wiki/File:GridAIControllerBlocks.jpg)

All AI Controller blocks visible on the back of a saucer-shaped flying drone

Tip: Small-grid drones are hard to spot in the wild. If you want your drone to be better visible, add an [Exhaust Pipe](https://spaceengineers.wiki.gg/wiki/Exhaust_Pipe "Exhaust Pipe") block (DLC)!

### How to give quick commands

Add an external button to the drone that toggles its AI Behaviour on/off, or sends it home to its connector, so you can quickly "catch" it again.

If the drone has an antenna and is within your antenna range, use the [Remote Access Screen](https://spaceengineers.wiki.gg/wiki/Remote_Access_Screen "Remote Access Screen") to change its behaviours through the control panel or to call it back in a pinch.

### How to keep the drone safe

Always start/end paths with the drone sitting on a safe  [![Icon Block Connector.png](https://spaceengineers.wiki.gg/images/thumb/7/7c/Icon_Block_Connector.png/21px-Icon_Block_Connector.png?30a126)](https://spaceengineers.wiki.gg/wiki/Connector "Connector") [Connector](https://spaceengineers.wiki.gg/wiki/Connector "Connector"), and add an action to a nearby button panel or cockpit toolbar that toggles the AI behaviour on/off on connected drones, so you don't have to send off and land each one manually.

### How to switch strategies

Sometimes you need a drone to switch strategies, not just between Task/Combat, but during combat to another combat strategy, or during a civilian task to another task. For example, during a longer journey, you want collision avoidance off and speed limit high; but while docking at the base, you want collision avoidance on and speed limit low. Or during combat, you want to "hit and run" as long as there is ammo, and switch to kamikaze "intercept" when out of ammo; or you want to retreat to base if damaged. Etc.

Don't try to manage different strategies in one AI block by changing a bunch of settings in flight. Build a separate AI block with settings for each strategy and make each good at doing its one task.

  
To let drones switch between different strategies:

1.  Add [Event Controllers](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") (EC) to detect the condition, such as "ammo cargo empty" or "battery low".
2.  Add extra Automaton blocks and set up each for a different behaviour.
3.  If the EC detects your custom condition, make it switch the other AI blocks of the same type off, and switch the "special strategy" AI block on.

## Troubleshooting

Notice the hints given by the block's colored light:

*   Green means the block is powered and ready, but the AI behavior is switched off, either manually, or automatically because the end of the path was reached.

*   Cyan means AI behavior is switched on and running.

*   Yellow means AI Behavior is switched off because there's an error. Check the block's status in the bottom right of its control panel.

*   Red means the block is switched off or the grid has no power.

Open the AI Block's Control Panel while it's running to watch its current status and target in the right column of the UI.

On the [Info Screen](https://spaceengineers.wiki.gg/wiki/Info_Screen "Info Screen"), enable **Show AI Functions**, then add an [Antenna](https://spaceengineers.wiki.gg/wiki/Antenna "Antenna") and set it to **Broadcast** to view waypoint info on your HUD in mid air.

If you sit in a cockpit on a AI/remote controlled drone, you may see a message "Someone else is using this ship."

The purchasable Automaton Pack also contains an [Emotion Controller](https://spaceengineers.wiki.gg/wiki/Emotion_Controller "Emotion Controller") that lets you output status info of the drone as a smiley face LCD.

## References

1.  [↑](#cite_ref-1 "Jump up") [https://www.spaceengineersgame.com/new-players/grid-ai-guide/](https://www.spaceengineersgame.com/new-players/grid-ai-guide/)
2.  [↑](#cite_ref-2 "Jump up") [https://twitter.com/marek\_rosa/status/1577396597243187224](https://twitter.com/marek_rosa/status/1577396597243187224)