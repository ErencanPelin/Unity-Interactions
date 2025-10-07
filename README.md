# Unity Interactions
An extensible unity interaction system. Versatile enough to be something that can be re-used across any project. From 2D to 3D to Multiplayer or single player.

## Getting Started
You have 2 options to use this package. Option 1 is to just import the repo as a Unity Package. Option 2 is to import the repo as a git submodule into your project.

### Importing as a Unity Package
You might want to do this if you just want to use the package as is and extend it for your project without worrying about making custom changes to it.
1. Copy the git URL `https://github.com/ErencanPelin/Unity-Interactions.git`
2. In Unity, Go to `Window` > `Package Management` > `Package Manager`
3. Click the `+` symbol in the top left
4. Select `Install package from git URL` and paste the URL you copied
5. The package will be installed into your Unity project under the `Packages` folder and added to your package manifest

### Importing as a Git Submodule
If you'd like the ability to just make custom changes as you go along, or are wanting to contribute to this package, importing it as a submodule gives you the ability to modify the code inside the package while using it in your current project as well.
1. Copy the git URL `https://github.com/ErencanPelin/Unity-Interactions.git`
2. In the `/Assets` directory of your Unity project, run the following command: ```git submodule add https://github.com/ErencanPelin/Unity-Interactions.git```
3. This will clone the repo into your `/Assets` folder. From there you probably should checkout a new branch so that any changes to the main branch don't get pulled in and impact functionality in your game. To checkout a new branch ```git checkout -b <your_branch_name>```

## How it works
### Interactables
[IInteractables](Core/IInteractable.cs) defines base methods for every interactable. See [InteractableDoor.cs](Samples/InteractableDoor.cs) for an example. An interactable's method use [InteractionContext](#interaction-context) as an input to decide whether or not the player can interact.

### Interaction Context
[IInteractionContext](Core/IInteractionContext.cs) defines the data that will be passed to each [IInteractable](#interactables). The Interactable decides what it does with that context - whether it modifies context as part of the interaction, or just reads the context to make a decision about whether or not it is interactable.

You can implement [IInteractionContext](Core/IInteractionContext.cs) in your own custom config, or extend [InteractionContextBase.cs](Core/IInteractionContext.cs) and add extra fields.

### Interaction Detector
The interaction detector detects how the player find interactables in the scene. You may just need to find the nearest, or all nearby interactables. You may need interactions to be detected based on where the mouse is or where the player is looking. You can implement your own custom detector function by implementing the [IInteractionDetector](Detectors/IInteractionDetector.cs) interface. There a few samples ready for you to use in [/Detectors](/Detectors).

## Contributing
See [CONTRIBUTING.md](CONTRIBUTING.md)

## License
See [LICENSE](LICENSE)