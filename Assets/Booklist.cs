using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Booklist : MonoBehaviour
{
    // Start is called before the first frame update


    [Serializable]
    public struct Book{
        public string Name;
        public string Author;
        public string Availability;
        public Sprite Cover;

    }

    [SerializeField] Book[] allBooks;

    void Start()
    {
        UnlockMouse();

        GameObject buttonTemplate = transform.GetChild(0).gameObject;
        GameObject g;

        int N = allBooks.Length;

        for(int i = 0 ; i < N ; i++){
            g = Instantiate (buttonTemplate, this.transform);
            g.transform.GetChild(0).gameObject.GetComponent <Text>().text = allBooks[i].Name;
            g.transform.GetChild(1).gameObject.GetComponent <Text>().text = allBooks[i].Author;
            g.transform.GetChild(2).gameObject.GetComponent <Text>().text = allBooks[i].Availability;
            g.transform.GetChild(3).gameObject.GetComponent <Image>().sprite = allBooks[i].Cover;
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
