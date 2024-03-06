all task complete

https://github.com/ArsenPetrossov/RPG_MiniGame/assets/157959288/d036d2b2-b259-4cd5-a026-0b833897ed0d

In front of you is a fragment of a game location, in which you need to solve several tasks.

The first of them is to move the player by pressing the LKM. That is, when the player presses the LKM on some part of the location, the character moves to this place. The mechanism of determining the direction to the click point is missing. It is the calculation of the correct direction vector for the _direction field that you need to describe.

The next task is to implement the destruction of the bridge. When the character approaches the bridge - it must be destroyed. 

Now pay attention to the Chest object - it is a chest located at the beginning of the location. Implement a call to this method when the player character approaches the chest.

A magic potion will fall out of the chest. You need to implement the mechanics of picking up the potion - when the player touches the potion, it disappears and the character starts to be highlighted along the outline. For this purpose, the Outline script is already attached to the Player object, highlighting the object along the outline of the meshes. The OutlineWidth property is set to 0 by default (the player is not highlighted). When selecting the potion, set the width to a value of 2.

When the player picks up a potion, he can go to the other side of the cliff, and the bridge should not collapse. You need to describe the appropriate behavior of the bridge. There is also an inactive Fire object on the stage, which are the torches on the other side of the cliff. When the player passes the bridge, the torches should light up. 

