using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receptionCollidorTrigger : MonoBehaviour
{
    public static receptionCollidorTrigger instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("fix this");
        }
        else
        {
            instance = this;
        }
    }

    public npcScript NPCscript;

    bool isTalking = false;

    float currentResponseTracker;

    
    public GameObject dialogueUI;
    public GameObject infoUI;
    public GameObject userInputUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;
    public InputField userInput;

    public GameObject uiTextObject; //press E text
    public bool isInRange = false;
    public bool isInMenu = false;

    public string questionText;

    // Start is called before the first frame update
    void Start()
    {
        uiTextObject.SetActive(false);
        dialogueUI.SetActive(false);
        infoUI.SetActive(false);
        userInputUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E) && (isInMenu == false))
        {
            dialogueUI.SetActive(true);
            isInMenu = true;
            Debug.Log("Key downed");

            //to pouse the screen and show the mouse properly
            //Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
          
            //start the dialogue queueing
            startCoversation();
        }

        if (Input.GetKeyDown(KeyCode.Q) && isInMenu)
        {
            closeReceptionUI();
            
        }

        //set current responce trackker
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            nextQuestion();
            
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            previousQuestion();
            
        }


        if (currentResponseTracker == 0 && NPCscript.playerDialogue.Length >=0)
        {
            playerResponse.text = NPCscript.playerDialogue[0];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[1];
            }
        }else if (currentResponseTracker == 1 && NPCscript.playerDialogue.Length >= 1)
        {
            playerResponse.text = NPCscript.playerDialogue[1];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[2];
            }
        }
        else if (currentResponseTracker == 2 && NPCscript.playerDialogue.Length >= 2)
        {
            playerResponse.text = NPCscript.playerDialogue[2];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[3];
            }
        }
        else if (currentResponseTracker == 3 && NPCscript.playerDialogue.Length >= 3)
        {
            playerResponse.text = NPCscript.playerDialogue[3];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[4];
            }
        }
        else if (currentResponseTracker == 4 && NPCscript.playerDialogue.Length >= 4)
        {
            playerResponse.text = NPCscript.playerDialogue[4];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[5];
            }
        }
        else if (currentResponseTracker == 5 && NPCscript.playerDialogue.Length >= 5)
        {
            playerResponse.text = NPCscript.playerDialogue[5];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[6];
            }
        }
        else if (currentResponseTracker == 6 && NPCscript.playerDialogue.Length >= 6)
        {
            playerResponse.text = NPCscript.playerDialogue[6];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[7];
            }
        }
        else if (currentResponseTracker == 7 && NPCscript.playerDialogue.Length >= 7)
        {
            playerResponse.text = NPCscript.playerDialogue[7];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[8];
            }
        }
        else if (currentResponseTracker == 8 && NPCscript.playerDialogue.Length >= 8)
        {
            playerResponse.text = NPCscript.playerDialogue[8];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[9];
            }
        }
        else if (currentResponseTracker == 9 && NPCscript.playerDialogue.Length >= 9)
        {
            playerResponse.text = NPCscript.playerDialogue[9];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[10];
            }
        }
        else if (currentResponseTracker == 10 && NPCscript.playerDialogue.Length >= 10)
        {
            playerResponse.text = NPCscript.playerDialogue[10];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[11];
            }
        }
        else if (currentResponseTracker == 11 && NPCscript.playerDialogue.Length >= 11)
        {
            playerResponse.text = NPCscript.playerDialogue[11];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[12];
            }
        }
        else if (currentResponseTracker == 12 && NPCscript.playerDialogue.Length >= 12)
        {
            NPCscript.playerDialogue[12] = "got from database the question";
            NPCscript.dialogue[13] = "got from database the asnwer";
            playerResponse.text = NPCscript.playerDialogue[12];
            if (Input.GetKeyDown(KeyCode.Return))
            {
                npcDialogueBox.text = NPCscript.dialogue[13];
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            uiTextObject.SetActive(true);
            isInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            uiTextObject.SetActive(false);
            isInRange = false;
        }
    }

    void startCoversation()
    {
        isTalking = true;
        currentResponseTracker = 0;
        npcName.text = NPCscript.npcName;
        npcDialogueBox.text = NPCscript.dialogue[0];

    }

    void endConversation()
    {
        isTalking = false;
    }

    public void changeIsInMenuFromDM()
    {
        isInMenu = false;
    }

    public void nextQuestion()
    {
        currentResponseTracker++;
        if (currentResponseTracker >= NPCscript.playerDialogue.Length - 1)
        {
            currentResponseTracker = NPCscript.playerDialogue.Length - 1;
            Debug.Log(currentResponseTracker);
        }
    }

    public void previousQuestion()
    {
        currentResponseTracker--;
        Debug.Log(currentResponseTracker);
        if (currentResponseTracker < 0)
        {
            currentResponseTracker = 0;
        }
    }

    public void closeReceptionUI()
    {
        dialogueUI.SetActive(false);
        infoUI.SetActive(false);
        isInMenu = false;
        Debug.Log("menu closed");
        //Time.timeScale = 1f;
        Cursor.visible = false;
        endConversation();
    }

    public void openInfoUI()
    {
        infoUI.SetActive(true);
    }

    public void closeInfoUI()
    {
        infoUI.SetActive(false);
    }

    public void openUserInputUI()
    {
        userInputUI.SetActive(true);
    }

    public void clsoeUserInputUI()
    {
        userInputUI.SetActive(false);
    }

    public void onButtonSubmit()
    {
        questionText = userInput.text;
        Debug.Log(questionText);
    }
}
