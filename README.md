## Currently Implemented
### Major Features
- NPC randomization (Vanilla Town NPCs only, no pets)
- Wall of Flesh + Princess goals
- Advanced configuration for manual flag activation (building off of Hardmode Starter)
- Advanced configuration for AP chat
### Minor Features
- Fixed early activation of "Begone, Evil!"
- Mute achievements on world load
# About This Fork

This is a public beta for some features that may one day be included in Terraria's core Archipelago implementation.

Only compatible with Calamity v2.0.6.2.

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
If you are playing with Calamity, you will have to manually install that mod in the same way. See the pins in the Archipelago discord's `#terraria` channel.
## Connecting to a Game
1. Launch tModLoader, navigate to Workshop > Manage Mods, and check to see if Archipelago Randomizer (Desp's Beta) is properly installed.
2. Configure the server address, port, slot/player name, password as necessary, and the rest to your liking.
3. Launch a world (creating a new one is recommended). If the chat displays "Archipelago is Active," you are connected successfully!

# License

Archipelago Terraria Client is licensed under MIT. The purple and white Archipelago logo was created by this repo's owner (Desperandos). The icon and collection button image used by this
mod are modified versions of the Archipelago logo, made to fit Terraria's style.

