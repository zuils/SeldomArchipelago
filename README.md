## Currently Implemented
For in-depth information on what each feature does, scroll down to the **Feature Explanation** section.
### Major Features
- Compatibility with Calamity 2.1.2 (Brainstorm update)
- NPC randomization (Vanilla Town NPCs only, no pets, **GFB compatibility untested!**)
- Wall of Flesh + Princess goals
  - Additional configuration for randomizing checks after the set goal
- Additional achievement classifications
- Advanced configuration for manual flag activation (building off of Hardmode Starter)
- Advanced configuration for AP chat
### Minor Features
- Fixed early activation of "Begone, Evil!"
- Mute achievements on world load

## Known Bugs
- Modded NPCs may rarely stop moving into a world connected to a slot with NPC Rando enabled.
  - This bug will persist on the world between reloads.
  - It is unknown whether this bug persists between different worlds attached to the same multiworld slot. *(Reports greatly appreciated)*
  - **WHAT TO DO:** Using the [Census - Town NPC Checklist](https://steamcommunity.com/sharedfiles/filedetails/?id=2687866031) mod will confirm if a modded NPC's conditions are met. If you see that a modded NPC can move in but won't spawn after a prolonged period:
    - Load another world with the Archipelago mod disabled and meet the conditions for them to spawn naturally
    - Spawn the NPC in manually with [Cheat Sheet](https://steamcommunity.com/sharedfiles/filedetails/?id=2563784437)

# About This Fork

This is a public beta for some features that may one day be included in Terraria's core Archipelago implementation.

Compatible with Calamity 2.1.2 (Workshop version)

Built off of the [official Archipelago branch](https://github.com/Seldom-SE/archipelago_terraria_client), developed and managed by Seldom.
If you're unclear about what Archipelago is, check out that page's README.

# Usage
To play with all features listed, you must generate and host a game using the packaged `.apworld` found on the releases page, and subscribe to (or manually install) the corresponding tModLoader mods.
## Generating a Game
This process is identical to that of most custom games:
1. Download the .apworld and place it in the `custom_worlds` directory of your Archipelago installation.
2. Launch `ArchipelagoLauncher.exe` and click `Generate Template YAMLs` in the menu.
- This should open the `Players/Templates` folder that should contain a new `Terraria_Desp_Beta.yaml` file for configuration.
3. Configure this file, save a copy, and place it in the `Players` directory, along with whichever `.yaml` files you want to generate with.
4. Navigate back to `ArchipelagoLauncher.exe` and click `Generate`.
5. Find the resulting `.zip` file in the `output` directory. From there, you can host the game easily on `archipelago.gg`.
## Installing the Mod
The simplest way to install the mod is to subscribe to it [here](https://steamcommunity.com/sharedfiles/filedetails/?id=3676602360).
Alternatively, you can download the `SeldomDespArchipelago.tmod` file in the corresponding release and place that in C:/Users/**YourPCName**/Documents/My Games/Terraria/tModLoader/Mods.
## Connecting to a Game
1. Launch tModLoader, navigate to Workshop > Manage Mods, and check to see if Archipelago Randomizer (Desp's Beta) is properly installed.
2. Configure the server address, port, slot/player name, password as necessary, and the rest to your liking.
3. Launch a world (creating a new one is recommended). If the chat displays "Archipelago is Active," you are connected successfully!

# Feature Explanation
## NPC Randomization
NPC Randomization is a setting you can enable in your `.yaml` prior to generating a multiworld.
If enabled: 
- The ability for each vanilla town NPC to move in becomes an item.
- Finding and talking to a rescuable NPC (Sleeping Angler, Bound Goblin, etc.) is a location.
- Meeting the conditions for an NPC to move in (barring receiving them as an AP item) and speaking to the resultant Ghost NPC is a location.
As of now, these only apply to vanilla Town NPCs that are not pets or wandering merchants.
### Notes
For a ghost or rescuable NPC to spawn, you need to meet the conditions that it would normally spawn under in an Archipelago randomizer.
For example, the Clothier ghost will move in after receiving the Post-Skeletron item, *not* after defeating Skeletron.
The Bound Tinkerer will appear after receiving Post-Goblin Army, *not* after defeating it in-game.

A real NPC will only move in if the corresponding item is received (you need the "Merchant" item for the Merchant to move in, etc.)

Both the real Truffle and the ghost Truffle will only spawn in a glowing mushroom field.
## New goals
These are additional goals you can enable in your `.yaml` prior to generating a multiworld.
- Wall of Flesh
- Princess
### Wall of Flesh
Victory is earned once the Wall of Flesh is summoned and defeated.
Note that this is intended for use with NPC randomization. It is strongly recommended you do not enable this goal with NPC randomization disabled, as this will result in an immediately beatable game.
### Princess
Victory is earned once the requirements for the Princess is met (all Vanilla town NPCs move in besides Santa Claus & Town Pets).
This goal randomizes everything up to and including Plantera. While created with NPC Randomization in mind, it is also perfectly playable otherwise.
## Advanced Manual Flag Configuration
Accessible through the client-side mod's config.
This expands upon the "Hardmode Starter" option in stable by allowing all vanilla & Calamity flags to be set for manual activation.
Setting a flag for manual activation means that once you receive the item, you gain the ability to trigger the corresponding item instead of it activating manually.
### Notes
**This option allows you to opt out of receiving flags like Hardmode too early and making early-game difficult. Please make sure to configure it before entering a world.**
Some good examples of flags to set as manual are Hardmode, Post-Plantera (for the dungeon changes especially) and Post-Moon Lord (which, in Calamity, adds incredibly tough enemies to the Hallow and Underworld).
## Advanced AP Chat Configuration
Accessible through the client-side mod's config.
Provides the ability to toggle the color and visibility of AP messages unrelated to your world.
# License

Archipelago Terraria Client is licensed under MIT. The purple and white Archipelago logo was created by this repo's owner (Desperandos). The icon and collection button image used by this
mod are modified versions of the Archipelago logo, made to fit Terraria's style.

