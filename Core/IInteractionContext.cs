// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 22/09/2025
// -----------------------------------------------------

using UnityEngine;

namespace UnityInteractions.Core
{
    /// <summary>
    /// The context passed to an interactable
    /// Implement this interface to add your own context data
    /// </summary>
    public interface IInteractionContext
    {
        /// <summary>
        /// Reference to the transform of the interactor (player, NPC, etc.)
        /// </summary>
        public Transform InteractorTransform { get; }

        /// <summary>
        /// The current interactable being interacted with in case the interactable needs to make a decision based on a current interaction
        /// <example>e.g. the player can only interact with something if they're not already interacting with something else</example>
        /// </summary>
        public IInteractable ActiveInteraction { get; }
    }
}