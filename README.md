# ShootAR

ShootAR is an AR game for Android built with the Unity game engine. Enemies appear in the area around the player
and the player uses the phone's camera and gyroscope to aim and shoot them.

## Table of contents
1. [Requirements](#requirements)
2. [Installation](#installation)
3. [Building](#building)
   1. [Required software](#required-software)
   2. [Downloading the source files](#downloading-the-source-files)
   3. [Compiling into APK](#compiling-into-apk)
4. [How to play](#how-to-play)

## Requirements
An Android device running at least version 5.0 ("Lollipop") and it must have gyroscope.

## Installation
*Note: By default, installation of APK files downloaded outside the Google Play is disabled.
Enable "Unknown Sources" in the phone's (Security) settings.*

## Building
*Below are the instructions on how to build the project. 

### Required software
In order to build the project yourself, you need to have [Unity](https://unity3d.com/) installed.

### Downloading the source files
Download the source files from [here](https://github.com/vikramrathore1799/game-begetter). 
Alternatively, download the source using git:
```
git clone https://github.com/vikramrathore1799/game-begetter.git <directory> 
```
or
```
git clone https://github.com/vikramrathore1799/game-begetter.git <directory>
```
where `<directory>` is the path to the desired location to download the files.

### Compiling into APK
Decompress the files if downloaded the ZIP or tarball version.

Create a folder named "apk" in the root of the project. (Technically, any folder would
be fine, but we have instructed git to ignore this one.)

Open the project folder in Unity:
* go to `File` –> `Build Settings...`
* if the selected platform is not Android, select it and hit the `Switch Platform` button
* set build system to `Gradle`

* to build a **development build**:
  * enable `Development Build`
  * (recommended) set compression method to `LZ4`
	
* to build a **release build**:
  * go to `File` –> `Build Settings...`
  * press the `Player Settings...` button
  * got to the `Inspector` tab and find the `Publishing Settings`
  * if you don't have a keystore file, you can create your own:
    * choose `Create a new Keystore...`, press `Browse Keystore` and type the name of the file to be created
    * type the new keystore password twice
  * if you have a keystore file:
    * choose `Use Existing Keystore`, press `Browse Keystore` and select the file
    * enter the keystore password
  * if you don't have a key:
    * open the drop–down menu next to *Alias* and select `Create a new key...`
    * fill the form that has popped up and hit `Create Key`
  * choose your key alias
  * enter your key password
  * return to the *Build Settings* window
  * (recommended) set compression method to `LZ4HC`
	
* hit `Build`
* choose a name for the APK file and save it inside the `apk` folder

Now the APK file can be transferred to an android device and install it.

Alternatively, instead of `Build`, connect an Android device with a USB cable to the computer, go to *Developer Options*
in your phone settings, enable *USB Debugging* and set *USB Configuration* to `MTP`. In the *Build Settings* window, set
*Run Device* to your device and hit `Build and Run`. This will do the same as `Build` in addition to installing the
game to the selected device.

*Note: If the device can not be detected by Unity, try restarting Unity while the device is already
physically connected to the computer.*

## How to play
To start playing hit the *Play* button in the main menu. Enemies will begin appearing in the space around you. Move
the phone around to find them, line them up with the aim dot and tap the screen to shoot them. For every enemy killed,
you get points. Destroying the capsules floating around you, gives you more bullets. Defeat all enemies to advance to the
next level. The game is over when player runs out of bullets or health.

To start playing with a higher difficulty, go to *Select* in the main menu and choose the starting level.
(warning: see (1) in the [known issues section](#known-issues).

## Credits
Unity store assets used:<br/>
Drone: https://assetstore.unity.com/packages/3d/low-poly-combat-drone-82234<br/>
Crasher: https://assetstore.unity.com/packages/3d/characters/aaron-s-assets-89273
