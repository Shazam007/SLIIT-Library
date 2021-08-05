using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dilaogueManager : MonoBehaviour
{
    public static dilaogueManager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("fix this");
        }
        else
        {
            instance = this;
        }
    }

    public GameObject dialogueBox;

    public Text npcName;
    public Text dialogueText;
    public Image npcPortrait;

    public float delay = 0.0001f;

    public Queue<dialogueBase.Info> dialogueInfo = new Queue<dialogueBase.Info>();

    public void enqueueDialogues(dialogueBase db)
    {
        dialogueInfo.Clear();
        foreach(dialogueBase.Info info in db.dialogueInfo)
        {
            dialogueInfo.Enqueue(info);
        }

        dequeueDialogues();
    }

    public void dequeueDialogues()
    {
        if(dialogueInfo.Count == 0)
        {
            dialogueBox.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;
            recepTrigger.instance.changeIsInMenuFromDM();
            return;
        }

        dialogueBase.Info info = dialogueInfo.Dequeue(); 

        npcName.text = info.npcName;
        dialogueText.text = info.dialogueText;
        npcPortrait.sprite = info.npcPortrait;

        StartCoroutine(TypeText(info));
    }

    IEnumerator TypeText(dialogueBase.Info info)
    {
        dialogueText.text = "";
        foreach(char c in info.dialogueText.ToCharArray())
        {
            yield return new WaitForSecondsRealtime(delay);
            dialogueText.text += c;


            //yield return new WaitForSeconds(delay);
            //dialogueText.text += c;
            
        }
    }
}
