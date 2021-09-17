using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search_active : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PCpanel;
    public GameObject EnterUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(EnterUI.activeSelf == true){
            // Debug.Log("TRUE");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EnterUI.SetActive(false);
            PCpanel.SetActive(true);
            print("space key was pressed");
        }

        }
        
    }
}
