using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDialogue : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;
    public DialogueUI DialogueUI => dialogueUI;
    public IInteractable Interactable { get; set; }

    void Update()
    {
        if (dialogueUI.IsOpen) return;

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Interactable != null)
            {
                Interactable.Interact(this);
            }
        }
    }
}
