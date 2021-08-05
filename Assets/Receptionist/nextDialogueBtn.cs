using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextDialogueBtn : MonoBehaviour
{
    public void getnextDialogue()
    {
        dilaogueManager.instance.dequeueDialogues();
    }
}
