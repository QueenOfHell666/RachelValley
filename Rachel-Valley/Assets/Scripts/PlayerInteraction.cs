using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRadius = 1.5f;
    public LayerMask interactableLayer;
    private InteractableObject currentInteractable;

    void Update()
    {
        DetectInteractable();

        if (currentInteractable != null && Input.GetKeyDown(KeyCode.E))
        {
            currentInteractable.Interact();
        }
    }

    private void DetectInteractable()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, interactionRadius, interactableLayer);
        if (colliders.Length > 0)
        {
            currentInteractable = colliders[0].GetComponent<InteractableObject>();
        }
        else
        {
            currentInteractable = null;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, interactionRadius);
    }
}
