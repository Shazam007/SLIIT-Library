using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPC file", menuName = "NPC file set", order = 2)]
public class npcScript : ScriptableObject
{
    public string npcName;
    //public Sprite npcPortrait;
    [TextArea(4, 15)]
    public string[] dialogue;
    [TextArea(4, 15)]
    public string[] playerDialogue;
}
