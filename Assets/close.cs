using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class close : MonoBehaviour
{

     public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void closebtn(){
       panel.SetActive(false);
    }
}
