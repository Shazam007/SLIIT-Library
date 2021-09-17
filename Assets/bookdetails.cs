using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bookdetails : MonoBehaviour
{

  public string  description; 
  public GameObject desc;
  public GameObject panel;


    public void MyMethod(string text) 
  {
    
    set_description(text);
     Debug.Log(get_description());
   
  }
    

      private void OnTriggerEnter(Collider other)
    {
        desc.transform.GetComponent <Text>().text = get_description();
        panel.SetActive(true);
        Debug.Log(get_description());
        
    }

    void set_description(string text_1){
        description = text_1;
    }

    string get_description(){
        return description;
    }

    


}
