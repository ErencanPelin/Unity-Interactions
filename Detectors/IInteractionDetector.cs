// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 07/10/2025
// -----------------------------------------------------

using System.Collections.Generic;
using UnityInteractions.Core;

namespace UnityInteractions.Detectors
{
    /// <summary>
    /// Detectors handle the logic to find potential objects the player can interact with
    /// Implement this for custom logic
    /// </summary>
    public interface IInteractionDetector
    {
        public IEnumerable<IInteractable> GetInteractables();
    }
}