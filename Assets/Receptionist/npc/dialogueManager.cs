using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager : MonoBehaviour
{
    public npcScript NPCscript;
    bool isTalking = false;

    float currentResponseTracker;

    public GameObject player;
    public GameObject dialogueUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;




    void Start()
    {
        dialogueUI.SetActive(false);
    }

    void inTruggerFucntion()
    {
        if(Input.GetKeyDown(KeyCode.E) && isTalking == false)
        {
            startCoversation();
        }else if(Input.GetKeyDown(KeyCode.E) && isTalking == true)
        {
            endConversation();
        }
    }

    void startCoversation()
    {
        isTalking = true;
        currentResponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = NPCscript.npcName;
        npcDialogueBox.text = NPCscript.dialogue[0];

    }

    void endConversation()
    {
        isTalking = false;
        dialogueUI.SetActive(false);
    }
}
