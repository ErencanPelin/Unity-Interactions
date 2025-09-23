// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 22/09/2025
// -----------------------------------------------------

using Interactions.Core;
using UnityEngine;
using UnityEngine.Events;

namespace Interactions.Interactables
{
    public sealed class InteractableDoor : MonoBehaviour, IInteractable
    {
        [SerializeField] private UnityAction onDoorOpen = delegate { };
        [SerializeField] private UnityAction onDoorClose = delegate { };

        private bool _isOpen;

        public string GetInteractionPrompt(IInteractionContext context) => "Open Door";

        public bool CanInteract(IInteractionContext context) => context.CurrentInteraction == null;

        public void Interact(IInteractionContext context)
        {
            _isOpen = !_isOpen;
            if (_isOpen) onDoorClose.Invoke();
            else onDoorOpen.Invoke();
        }
    }
}