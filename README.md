#Glitch Garden
Attackers are attacking defend the arena by spawning the defenders.
Game available for downloading at
<a href='https://play.google.com/store/apps/details?id=com.VirginMonkStudios.GlitchTheGame&hl=en&utm_source=global_co&utm_medium=prtnr&utm_content=Mar2515&utm_campaign=PartBadge&pcampaignid=MKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1'><img alt='Get it on Google Play' src='https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png' height = 100px/></a>
##Scripting Classes
<b>Attacker.cs</b> - Controlles all the Attackers, Parent class of all the Attackers. (Lizard, Fox, Chicken, Piggy).

Button.cs - Responsible for taking the user from the user, as game is for touch screen mobile phones as well as Computers so the input is taken by the tap of user that tap is read by this Class.
Chicken.cs - Manages the functionality of Chicken.
Defender.cs - Controlles all the Defenders, Parent class of all the Defenders. (Tryphy, Cactus, Gnome, Grave Stome, Scarecrow)
DefenderSpawner.cs - When user taps in the game for Spawning the Defenders for defending the functionality of Spawn of Defenders is managed by this Class.
FadeIn.cs - For Fade in Effet on the loading of Scene.
Fox.cs - Manages the functionality of Fox.
GameMask.cs - When user play the game for first time introductory overlay appears that overlay is managed by this Class.
GameTimer.cs - Scene timeout for winning a level is managed by this class.
Health.cs - Health of both Attackers and Defenders is Managed by this class.
LevelManager.cs - This class is having functions for making the transition easy from on scene to another.
Lizard.cs - Manages the functionality of Lizard.
Loose.cs - Conditions for loosing the game are defined in this class.
MusicManager.cs - Class for managing music during the scenes, having capabilities to keep music playing during the switch of scene.
OptionsController.cs - Manages Options, This class is managing all the functionality of Options Scene.
Pause.cs - Manages pause and Resume during the game play.
Piggy.cs - Manages the functionality of Piggy.
PlayerPrefsManager.cs - Manages Data stored in PlayerPrefs
Projectile.cs - Controls all the projectiles like speed of projectils, damage done by an individual projectile etc.
ReloadLevel.cs - Reloads the level.
Shedder.cs -  Used for destroying the projectiles and Attackers which paas from the game arena.
Shooter.cs - Controls the instantiation of projectiles.
Spawner.cs - Used for instantiation of Attackers.
StarDisplay.cs - used for counting the number of Stars(currency in context of game). This class counts the number of stars generated by Tropy and detects when a defender is Spawned.
Stone.cs - Manages the functionality of GraveStone.
