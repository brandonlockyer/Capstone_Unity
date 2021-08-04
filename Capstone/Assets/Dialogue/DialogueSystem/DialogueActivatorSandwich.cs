using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActivatorSandwich : MonoBehaviour, IInteractable
{
    [SerializeField] private DialogueObject dialogueObject;

    public bool questItemDialogue;
    public GameObject player;

    public void Update()
    {
        questItemDialogue = player.GetComponent<PlayerMovementDialogue>().questItem;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out PlayerMovementDialogue player) && questItemDialogue == true)
        {
            player.Interactable = this;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out PlayerMovementDialogue player) && questItemDialogue == true)
        {
            if (player.Interactable is DialogueActivator dialogueActivator && dialogueActivator == this)
            {
                player.Interactable = null;
            }
        } 
    }

    public void Interact(PlayerMovementDialogue player)
    {
        player.DialogueUI.ShowDialogue(dialogueObject);
    }
}
