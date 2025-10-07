# Unity Interactions
An extensible unity interaction system. Versatile enough to be something I can re-use across many different projects, 2D, 3D, Multiplayer or single player.

## How it works
### Interactables
[IInteractables](Core/IInteractable.cs) defines base methods for every interactable. See [InteractableDoor.cs](Samples/InteractableDoor.cs) for an example. An interactable's method use [InteractionContext](#interaction-context) as an input to decide whether or not the player can interact.

### Interaction Context
[IInteractionContext](Core/IInteractionContext.cs) defines the data that will be passed to each [IInteractable](#interactables). The Interactable decides what it does with that context - whether it modifies context as part of the interaction, or just reads the context to make a decision about whether or not it is interactable.

You can implement [IInteractionContext](Core/IInteractionContext.cs) in your own custom config, or extend [InteractionContextBase.cs](Core/IInteractionContext.cs) and add extra fields.

### Interaction Detector
The interaction detector detects how the player find interactables in the scene. You may just need to find the nearest, or all nearby interactables. You may need interactions to be detected based on where the mouse is or where the player is looking. You can implement your own custom detector function by implementing the [IInteractionDetector](Detectors/IInteractionDetector.cs) interface. There a few samples ready for you to use in [/Detectors](/Detectors).