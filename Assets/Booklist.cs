using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booklist : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UnlockMouse();

        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;

        for(int i = 0 ; i < 5 ; i++){
            g = Instantiate (buttonTemplate, transform);
        }

        Destroy(buttonTemplate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UnlockMouse(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
