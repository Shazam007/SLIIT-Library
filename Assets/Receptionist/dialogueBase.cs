using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newDialogue", menuName = "Dialogue", order = 1)]
public class dialogueBase : ScriptableObject
{
    [System.Serializable]
    public class Info
    {
        public string npcName;
        public Sprite npcPortrait;
        [TextArea(4, 8)]
        public string dialogueText;
    }

    [Header("Add dialogue info below")]
    public Info[] dialogueInfo;

}
