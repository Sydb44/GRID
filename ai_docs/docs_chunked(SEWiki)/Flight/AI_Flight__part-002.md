    *   For planetary flight, add extra ventral thrusters to counteract gravity, and lower the roll and pitch angles.
*   If the drone overshoots the waypoints, first try decreasing the speed limit to under 10 m/s.
*   If it flies slow stop-and-go in open space, then switch [Precision Mode](https://spaceengineers.wiki.gg/wiki/Autopilot#Precision_Mode "Autopilot") off.
*   If it approaches waypoints too sloppily, then switch [Precision Mode](https://spaceengineers.wiki.gg/wiki/Autopilot#Precision_Mode "Autopilot") on.
*   If it hesitates in front of hangar doors, connectors, asteroid caves, etc., then switch [Collision Avoidance](https://spaceengineers.wiki.gg/wiki/Autopilot#Collision_Avoidance "Autopilot") off.
*   If it crashes into bases and asteroids, then switch [Collision Avoidance](https://spaceengineers.wiki.gg/wiki/Autopilot#Collision_Avoidance "Autopilot") on.

If only one set of settings does not cover your situation, you can be flexible:

*   When used together with [Autopilot](https://spaceengineers.wiki.gg/wiki/Autopilot "Autopilot"), toggle Collision Avoidance or Precision Mode on/off at waypoints as part of the recording.
*   Build two AI Flight blocks with different settings, and use an [Event Controller](https://spaceengineers.wiki.gg/wiki/Event_Controller "Event Controller") to switch one on and one off. Optimise one configuration for fast open-space flight and the other for a slow careful docking approach.

Note: If your drone uses thrusters or gyroscopes on override, the AI Flight block switches these off and takes control when it activates.

## Construction

If [Progression](https://spaceengineers.wiki.gg/wiki/Progression "Progression") is on, build a Basic Assembler and any light first to unlock this block.

The block is 1x1x1 blocks in size and it exists for small and large grid.

It can attach to other blocks on all sides and uses 10 kW. Look at the arrows on the side to place it forward facing. Optimally align it with the Connector/Merge Block/Magnetic Plate/etc. because all navigation will be relative to the AI Flight block.

The block is not expensive and can be built in early game, similar to an ore detector.

## Recipe

| [![Icon Block AI Flight.png](https://spaceengineers.wiki.gg/images/thumb/c/c0/Icon_Block_AI_Flight.png/21px-Icon_Block_AI_Flight.png?40cc07)](https://spaceengineers.wiki.gg/wiki/AI_Flight "AI Flight") AI Flight |     |     |     |     |
| --- | --- | --- | --- | --- |
| Component | Large Ship/Station  <br>Required | Large Ship/Station  <br>Optional | Small Ship  <br>Required | Small Ship  <br>Optional |
| [![Icon Item Interior Plate.png](https://spaceengineers.wiki.gg/images/thumb/7/77/Icon_Item_Interior_Plate.png/21px-Icon_Item_Interior_Plate.png?d80f8e)](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") [Interior Plate](https://spaceengineers.wiki.gg/wiki/Interior_Plate "Interior Plate") | 20  | —   | 2   | —   |
| [![Icon Item Computer.png](https://spaceengineers.wiki.gg/images/thumb/7/72/Icon_Item_Computer.png/21px-Icon_Item_Computer.png?65c1a4)](https://spaceengineers.wiki.gg/wiki/Computer "Computer") [Computer](https://spaceengineers.wiki.gg/wiki/Computer "Computer") | 20  | —   | 10  | —   |
| [![Icon Item Motor.png](https://spaceengineers.wiki.gg/images/thumb/2/2c/Icon_Item_Motor.png/21px-Icon_Item_Motor.png?4a2f3f)](https://spaceengineers.wiki.gg/wiki/Motor "Motor") [Motor](https://spaceengineers.wiki.gg/wiki/Motor "Motor") | 4   | —   | 2   | —   |
| [![Icon Item Detector Components.png](https://spaceengineers.wiki.gg/images/thumb/e/e8/Icon_Item_Detector_Components.png/21px-Icon_Item_Detector_Components.png?ec13ed)](https://spaceengineers.wiki.gg/wiki/Detector_Components "Detector Components") [Detector Components](https://spaceengineers.wiki.gg/wiki/Detector_Components "Detector Components") | 20  | —   | 4   | —   |
| [![Icon Item Construction Comp..png](https://spaceengineers.wiki.gg/images/thumb/4/45/Icon_Item_Construction_Comp..png/21px-Icon_Item_Construction_Comp..png?cdc26f)](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") [Construction Comp.](https://spaceengineers.wiki.gg/wiki/Construction_Comp. "Construction Comp.") | 30  | —   | 5   | —   |
| [![Icon Item Steel Plate.png](https://spaceengineers.wiki.gg/images/thumb/4/4c/Icon_Item_Steel_Plate.png/21px-Icon_Item_Steel_Plate.png?437e3a)](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") [Steel Plate](https://spaceengineers.wiki.gg/wiki/Steel_Plate "Steel Plate") | —   | 20  | —   | 2   |