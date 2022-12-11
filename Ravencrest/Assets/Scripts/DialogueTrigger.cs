using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public string dialogueText;
    public bool showOnce = true;
    private bool hasBeenShowned = false;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasBeenShowned)
        {

            GameManager.Instance.hud.SetDialogueText(dialogueText);
            GameManager.Instance.hud.ShowDialogue();
            if (showOnce)
            {
                hasBeenShowned = true;
            } else
            {
                hasBeenShowned = false;

            }
            //Set dialoguetrigger to active
        }
    }
}
