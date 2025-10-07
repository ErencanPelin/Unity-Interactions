// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 22/09/2025
// -----------------------------------------------------

using UnityInteractions.Core;
using UnityEngine;
using UnityEngine.Events;

namespace UnityInteractions.Samples
{
    public sealed class InteractableDoor : MonoBehaviour, IInteractable
    {
        [SerializeField] private UnityAction onDoorOpen = delegate { };
        [SerializeField] private UnityAction onDoorClose = delegate { };

        private bool isOpen;

        public string GetInteractionPrompt(IInteractionContext context) => "Open Door";

        public bool CanInteract(IInteractionContext context) => context.ActiveInteraction == null;

        public void Interact(IInteractionContext context)
        {
            isOpen = !isOpen;
            if (isOpen) onDoorClose.Invoke();
            else onDoorOpen.Invoke();
        }
    }
}