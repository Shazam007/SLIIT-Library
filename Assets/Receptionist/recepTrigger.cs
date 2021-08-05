using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recepTrigger : MonoBehaviour
{
    public static recepTrigger instance;
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

    public dialogueBase dialogue;

    public GameObject uiTextObject;
    public GameObject dialogueUI;
    public bool isInRange = false;
    public bool isInMenu = false;
    
    // Start is called before the first frame update
    void Start()
    {
        uiTextObject.SetActive(false);
        dialogueUI.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange && Input.GetKeyDown(KeyCode.E) && (isInMenu == false)){
            dialogueUI.SetActive(true);
            isInMenu = true;
            Debug.Log("Key downed");

            //to pouse the screen and show the mouse properly
            Time.timeScale = 0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            //start the dialogue queueing
            triggerDialogue();
        }

        if(Input.GetKeyDown(KeyCode.Q) && isInMenu){
            dialogueUI.SetActive(false);
            isInMenu = false;
            Debug.Log("menu closed");
            Time.timeScale = 1f;
            Cursor.visible = false;
        }
    }


    private void OnTriggerEnter(Collider other) {
       if (other.gameObject.tag == "Player")
        {
            uiTextObject.SetActive(true);
            isInRange = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            uiTextObject.SetActive(false);
            isInRange = false;
        }
    }
    public void triggerDialogue()
    {
        dilaogueManager.instance.enqueueDialogues(dialogue);
    }

    public void changeIsInMenuFromDM()
    {
        isInMenu = false;
    }

    

}
