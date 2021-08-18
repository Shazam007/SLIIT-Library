using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerUI : MonoBehaviour
{

    public GameObject ComputerUIpanel;
    public void onClickClose(){
        
        ComputerUIpanel.SetActive(false);
    }

}
