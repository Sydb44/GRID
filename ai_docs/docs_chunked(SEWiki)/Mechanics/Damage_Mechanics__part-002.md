Sources of explosive damage:

*   Any block that contains [explosives](https://spaceengineers.wiki.gg/wiki/Explosives "Explosives") or [ammunition](https://spaceengineers.wiki.gg/wiki/Ammunition "Ammunition") in its inventory will explode when destroyed by taking damage. The explosion radius is based on the amount and type of munitions that were inside the inventory.
*   Destroyed [Hydrogen Tank](https://spaceengineers.wiki.gg/wiki/Hydrogen_Tank "Hydrogen Tank") and [Oxygen Tank](https://spaceengineers.wiki.gg/wiki/Oxygen_Tank "Oxygen Tank") explode and deal damage based on the amount of fuel left inside at the time of their destruction.
*   Dropped [Explosives](https://spaceengineers.wiki.gg/wiki/Explosives "Explosives") detonated with weapon shots deal damage to blocks in a (1cm\*number of explosives in stack) blast radius.
*   [Rockets](https://spaceengineers.wiki.gg/wiki/Rocket "Rocket") have a 4m blast radius on impact, doing damage to blocks proportionally to their distance from the center of the blast.
*   [Warheads](https://spaceengineers.wiki.gg/wiki/Warhead "Warhead") explode when shot (when armed), or after a countdown, or after manual detonation.

For more details see respective item's page.

List of weapons dealing explosive damage can be found at [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons") and [Character Weapons](https://spaceengineers.wiki.gg/wiki/Character_Weapons "Character Weapons").

Also, the modding section's [Explosions](https://spaceengineers.wiki.gg/wiki/Modding/Reference/Explosions "Modding/Reference/Explosions") page has all the little details about explosion behaviors.

## Penetration Damage

Certain weapons deal penetration damage which only penetrates blocks and characters. It is completely blocked by voxels and deals no damage to them.

The damage is consumed for every block it hits on its path until it can no longer destroy block (or character).  
For example: a projectile with 6000 penetration damage comes across 3 large light armor blocks (2500hp each) along its path. It has enough damage to destroy the first two and now the projectile only has 1000 damage remaining which it deals to the 3rd armor block and stops.

List of weapons dealing penetration damage can be found at [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons").

## Ricochet

Certain weapons support a ricochet system which has a chance for the projectile to bounce off blocks depending on the angle between the projectile's trajectory and the surface. The relation between chance and angle is linear but the numbers differ for each caliber.

Ricochets only work when hitting blocks.

Once the projectile does ricochet, it will deal a fixed amount of damage to the hit block and reduces the projectile's penetration damage by that same amount.

List of weapons that can ricochet can be found at [Block Weapons](https://spaceengineers.wiki.gg/wiki/Block_Weapons "Block Weapons").

## Armor Durability

Welded and unwelded blocks have the same mass, welding them only adds durability in the form of hitpoints.

Each block's health, measured in Hitpoints, is equal to the sum of the health of its components, meaning that larger, more expensive, und undamaged blocks also have higher durability.  
In short, the mass stays constant but hitpoints can decrease due to damage, and increase after repairs.

Blocks take bonus damage equal to the percentage missing from the built percentage. Example: a block built to 80% will take +20% more damage from all sources.  
This bonus damage will **not** increase when you reduce the block's health percentage with damage.