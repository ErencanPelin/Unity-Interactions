// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 22/09/2025
// -----------------------------------------------------

namespace Interactions.Core
{
    public interface IInteractable
    {
        public bool CanInteract(IInteractionContext context);
        public void Interact(IInteractionContext context);
        public string GetInteractionPrompt(IInteractionContext context);
    }
}