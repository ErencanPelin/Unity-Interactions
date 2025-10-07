// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 22/09/2025
// -----------------------------------------------------

using UnityInteractions.Core;
using UnityEngine;

namespace UnityInteractions.Models
{
    /// <summary>
    /// A basic implementation of IInteractionContext. Use this or implement your own. Or extend this class.
    /// </summary>
    public class InteractionContextBase : IInteractionContext
    {
        public Transform InteractorTransform { get; private set; }
        public IInteractable ActiveInteraction { get; private set; }

        // Builder pattern for initialising interaction context values
        public InteractionContextBase WithInteractorTransform(Transform interactorTransform)
        {
            InteractorTransform = interactorTransform;
            return this;
        }

        public InteractionContextBase WithCurrentInteraction(IInteractable currentInteraction)
        {
            ActiveInteraction = currentInteraction;
            return this;
        }
    }
}