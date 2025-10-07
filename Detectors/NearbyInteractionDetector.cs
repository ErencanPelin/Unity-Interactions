// -----------------------------------------------------
// Copyright (c) 2025 Erencan Pelin. All Rights Reserved.
// 
// Author: Erencan Pelin
// Date: 07/10/2025
// -----------------------------------------------------

using System.Collections.Generic;
using UnityEngine;
using UnityInteractions.Core;

namespace UnityInteractions.Detectors
{
    /// <summary>
    /// Finds interactables within the given range in 2D space
    /// </summary>
    public sealed class NearbyInteractionDetector2D : IInteractionDetector
    {
        private readonly float range;
        private readonly LayerMask detectionMask;
        private readonly IInteractionContext interactionContext;

        private Collider2D[] hitsCache; //store array here to avoid garbage collection (GC)
        private readonly List<IInteractable> interactableCache; //create list once to avoid GC

        public NearbyInteractionDetector2D(IInteractionContext interactionContext, float range, LayerMask detectionMask)
        {
            this.interactionContext = interactionContext;
            this.range = range;
            this.detectionMask = detectionMask;
            interactableCache = new List<IInteractable>();
        }

        public IEnumerable<IInteractable> GetInteractables()
        {
            Vector2 rootPosition = interactionContext.InteractorTransform.position; //z value is dropped
            hitsCache = Physics2D.OverlapCircleAll(rootPosition, range, detectionMask);
            interactableCache.Clear();
            foreach (var hit in hitsCache)
            {
                // ignore anything that is not interactable
                if (!hit.TryGetComponent(out IInteractable interactable))
                    continue;
                // ignore anything that we can't interact with
                if (!interactable.CanInteract(interactionContext))
                    continue;
                // add to list of interactables to be returned
                interactableCache.Add(interactable);
            }
            return interactableCache;
        }
    }
}