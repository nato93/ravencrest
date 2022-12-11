using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.UI;


public class HUD : MonoBehaviour
{

    public GameObject dialoguePanel;
    public TMPro.TextMeshProUGUI dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDialogueText(string text)
    {
        dialogueText.text = text.ToString();
    }

    public void ShowDialogue()
    {
        dialoguePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseDialogue()
    {
        dialoguePanel.SetActive(false);
        Time.timeScale = 1;


    }
}
