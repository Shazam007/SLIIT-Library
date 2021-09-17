using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class open_UI : MonoBehaviour
{
    public GameObject UIpanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        UIpanel.SetActive(true);
        // Debug.Log("Enter");
    }

    void OnTriggerExit(Collider other)
    {
        UIpanel.SetActive(false);
    }
}
