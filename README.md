# Symphony of the Night Randomizer Tools

[![(latest) release | GitHub](https://img.shields.io/github/release/TalicZealot/SotnRandoTools.svg?logo=github&logoColor=333333&style=popout)](https://github.com/TalicZealot/SotnRandoTools/releases/latest)

A collection of tools to enhance the [Castlevania:Symphony of the Night Randomizer](https://sotn.io) experience.

This tool and the accompanying library and app are open source. The idea is to implement these features with the perspective of SotN players and provide the source for other developers to learn from and contribute just like the randomizer itself.

## Associated Projects
* [SotnApi](https://github.com/TalicZealot/SotnApi)
* [SimpleLatestReleaseUpdater](https://github.com/TalicZealot/SimpleLatestReleaseUpdater)
* [SotN Randomizer Source](https://github.com/3snowp7im/SotN-Randomizer)

## Installation
This tool requires Bizhawk version 2.6 or higher.
Download the full version from the [latest release](https://github.com/TalicZealot/SotnRandoTools/releases/latest) that looks like this `SotnRandoTools-x.x.x.zip`
Right click on it and select `Extract all...` then navigate to your BizHawk 2.6+ folder and press `Extract`.
File structure should look like this:
```
BizHawk
└───ExternalTools
│   │   SotnRandoTools.dll
│   │
│   └───SotnRandoTools
│       │   SotnApi.dll
│       │   ...
```

## Usage
After launching the game in BizHawk open through ```Tools > Extarnal Tool > Symphony of the Night Randomizer Tools```
Set your preferences and open the tool you want to use. You can then minimize the main tools window, but don't close it.
Every tool's window possition and the Tracker's size are all saved and will open where you last left them.
If the Extarnal Tool says that the game is not supported for the tool and BizHawk is displaying a question mark in the lower left corner your rom is either not recognized or you have to make sure the cue file is pointing to the correct files. I recommend creating a separate folder for Randomizer where you copy both tracks and the cue and replace track1 every time you randomize.

## Updating
On lunching the tool it will check for a new release and inform the user. If there is a newer release the update button apepars. Clicking it shuts down BizHawk and updates the tool. If it displays "Installation failed" please run the updater manually by going to ```BizHawk\ExternalTools\SotnRandoTools\Updater\SimpleLatestReleaseUpdater.exe``` or get the [latest release](https://github.com/TalicZealot/SotnRandoTools/releases/latest) from GitHub and update manually.

## Autotracker
The new tracker has been re-written from the ground up for better performance and usability. Can be manually rescaled and supports different rendering modes. Saves size and location. Locations are drawn on the game map iself instead of relying on BizHawk GUI. It doesn't rely on the PSX display mode anymore and automatically detects everything it needs.

## Co-Op
Coop requires the host to have the port they want to use forwarded. Hosting automatically copies your address(ip:port) to the clipboard. The other player uses that address to connect. Please be careful to not leak your IP!
The Select button is used to send the currently highlighted item in the inventory or relic in the relic menu.
The Circle button is used to perform an assist action. Using a potion in your inventory and activating it for the other player.

## Khaos
Video setup guide: [https://www.youtube.com/watch?v=cDUYwATR7k8](https://www.youtube.com/watch?v=cDUYwATR7k8)
Khaos is in an alpha stage at the moment. I am still working on implementing the in-game effects and making them stable. In order to engage in chat interaction you must set up StreamlabsChatbot with their internal custom currency. Then add commands that will fill the input text file, that Khaos reads. Improt the command group, then edit the file paths and prices to your preferences: [https://raw.githubusercontent.com/TalicZealot/SotnRandoTools/main/BotCommands/KhaosCommands.abcomg](https://raw.githubusercontent.com/TalicZealot/SotnRandoTools/main/BotCommands/KhaosCommands.abcomg) `right click > Save Link As...`

## Useful links
* [SotN Randomizer](https://sotn.io)
* [Latest BizHawk release](https://github.com/TASVideos/BizHawk/releases/latest)
