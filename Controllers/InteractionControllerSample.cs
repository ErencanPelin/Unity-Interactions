// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 22/09/2025
// -----------------------------------------------------

using Interactions.Core;
using Interactions.Models;
using UnityEngine;

namespace Interactions.Controllers
{
    /// <summary>
    /// A sample interaction controller to show how to create and use an interaction context
    /// </summary>
    public class InteractionControllerSample : MonoBehaviour
    {
        private IInteractionContext _interactionContext;

        private void Awake()
        {
            _interactionContext = new InteractionContextBase()
                .WithInteractorTransform(transform)
                .WithCurrentInteraction(null);
        }
    }
}
