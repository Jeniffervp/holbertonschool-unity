# 0x06. Unity - Assets: UI

![N|Solid](https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Unity_Technologies_logo.svg/413px-Unity_Technologies_logo.svg.png)

Project from Holberton School to learn the basic concepts of unity.

### Task

`Mandatory`

| Task | Description |
| ---- | ----------- |
| 0. Leveling up | We’ll be adding on to the last project to add a menu and UI (see example ). Duplicate your 0x05-unity-assets_models_textures directory and rename it 0x06-unity-assets_ui. Create two more Scenes in 0x06-unity-assets_ui. For each new scene, create a new path of platforms for the Player to navigate through. |
| 1. Choose your own adventure | The next few tasks will be creating UI elements using imported images to build a menu that allows the player to choose a level. Download the Google font “Changa” and place in a Changa folder into a new folder called Fonts in the Assets folder (the final path should be Assets/Fonts/Changa/<.ttf files>). All text should use this font, so change TimerText‘s font as well. Download these images into a folder called UI in the Textures folder. Set their Texture Type to Sprite (2D and UI). Create a new Scene called MainMenu. |
| 2. Option in | Create a new Scene called Options. |
| 3. Pushing buttons | Create a new C# script called MainMenu.cs. In the MainMenu scene, script the level buttons scene so that choosing Level01, Level02, or Level03 loads the corresponding scene. |
| 4. Wait, hold on, time out | Inside the Level01 Scene, create a new Canvas and using the image as a guide, create a pause screen with the following objects. |
| 5. Es-ca-pé | Create a new C# script called PauseMenu.cs. Add a method to this script so that when the player presses Esc while playing the game, the game should pause and the PauseCanvas should become active. The timer should also pause. |
| 6. Even more button pushing | In the PauseMenu and PauseMenu.cs, script the RestartButton so that it reloads the level scene that the player is currently on. |
| 7. Up is down, down is up | In the CameraController.cs script, add the ability to invert the Y axis. Create a public bool called isInverted. The camera should be able to work in two ways: -Normal: The camera should move up when the mouse moves up and down when the mouse moves down. -Inverted: The camera should move up when the mouse moves down and down when the mouse moves up. |
| 8. But Y? | In Options and OptionsMenu.cs, script it so that checking the InvertYToggle in the menu and applying the changes reverses the camera/mouse movements in the level scene. |
| 9. A winner is you | In the Level01 Scene, create a new Canvas and using the image as a guide, create a win screen with the following objects. |
| 10. Winning isn't everything | Edit WinTrigger.cs so that when the player touches the flag, WinCanvas becomes active. Add a method to Timer.cs so that when the player touches the flag, the player’s finish time is displayed in FinalTime in WinCanvas. |
| 11. Still under development | Scenes in Build: MainMenu: Options;Level01;Level02;Level03;Create three builds of all scenes above in the Builds directory. Windows and Linux builds should be set to x86_64 architecture |

### Credits

Skyboxes: [Farland Skies - Cloudy Crown](https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004)

Models: [Kenney's Nature Pack Extended](https://kenney.nl/assets/nature-pack-extended)