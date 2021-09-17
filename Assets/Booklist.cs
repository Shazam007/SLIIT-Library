using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;


public static class ButtonExtension
{
	public static void AddEventListener<T> (this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener (delegate() {
			OnClick (param);
		});
	}
}


public static class MyStringExtensions
{
  public static bool Like(this string toSearch, string toFind)
  {
    return new Regex(@"\A" + new Regex(@"\.|\$|\^|\{|\[|\(|\||\)|\*|\+|\?|\\").Replace(toFind, ch => @"\" + ch).Replace('_', '.').Replace("%", ".*") + @"\z", RegexOptions.Singleline).IsMatch(toSearch);
  }
}
public class Booklist : MonoBehaviour
{
    // Start is called before the first frame update

    public bookdetails details;
    public Image lcationpoint;
    public GameObject point;

    public GameObject catagory01;
    public GameObject catagory02;
    public GameObject catagory03;
    public GameObject catagory04;
    public GameObject catagory05;
    public GameObject catagory06;
    public GameObject catagory07;
    public GameObject catagory08;
    public GameObject catagory09;
    public GameObject catagory10;
    public GameObject catagory11;
    public GameObject catagory12;
 
    [Serializable]
    public struct Book{
        public string Name;
        public string Author;
        public string Availability;
        public Sprite Cover;
        public string category;
        public string Description;

    }

    public GameObject buttonTemplate;
    public InputField searchTextinput;

    [SerializeField] Book[] allBooks;

   

    
    GameObject g;
    void Start()
    {
        UnlockMouse();

        int N = allBooks.Length;

        for(int i = 0 ; i < N ; i++){
            g = Instantiate (buttonTemplate, this.transform);
            g.transform.GetChild(0).gameObject.GetComponent <Text>().text = allBooks[i].Name;
            g.transform.GetChild(1).gameObject.GetComponent <Text>().text = allBooks[i].Author;
            if(allBooks[i].Availability == "yes"){
                g.transform.GetChild(2).gameObject.GetComponent <Image>().color = Color.green;
            }else{
                g.transform.GetChild(2).gameObject.GetComponent <Image>().color = Color.red;
            }
            // g.transform.GetChild(2).gameObject.GetComponent <Text>().text = allBooks[i].Availability;

            g.transform.GetChild(3).gameObject.GetComponent <Image>().sprite = allBooks[i].Cover;

            g.GetComponent <Button> ().AddEventListener (i, ItemClicked);
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UnlockMouse(){
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    	void ItemClicked (int itemIndex)
	{
		Debug.Log ("------------item " + itemIndex + " clicked---------------");
		Debug.Log ("name " + allBooks[itemIndex].Name);
        


        catagory01.SetActive(false);
        catagory02.SetActive(false);
        catagory03.SetActive(false);
        catagory04.SetActive(false);
        catagory05.SetActive(false);
        catagory06.SetActive(false);
        catagory07.SetActive(false);
        catagory08.SetActive(false);
        catagory09.SetActive(false);
        catagory10.SetActive(false);
        catagory11.SetActive(false);
        catagory12.SetActive(false);


        if(allBooks[itemIndex].category == "01"){
                catagory01.SetActive(true);
                details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "02"){
                 catagory03.SetActive(true);
                    details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "03"){
             catagory04.SetActive(true);
                 details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "04"){
             catagory05.SetActive(true);
              details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "05"){
             catagory06.SetActive(true);
              details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "06"){
             catagory07.SetActive(true);
               details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "07"){
             catagory08.SetActive(true);
              details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "08"){
             catagory09.SetActive(true);
            details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "09"){
             catagory10.SetActive(true);
             details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "10"){
             catagory11.SetActive(true);
            details.MyMethod(allBooks[itemIndex].Description);
        }else if(allBooks[itemIndex].category == "11"){
             catagory12.SetActive(true);
            details.MyMethod(allBooks[itemIndex].Description);
        }
        
       
	}



    public void serach(){

            String SearchValue = searchTextinput.text;
        

            foreach (Transform child in this.transform) {
                    GameObject.Destroy(child.gameObject);
            }

        int N = allBooks.Length;

        for(int i = 0 ; i < N ; i++){


            Debug.Log(allBooks[i].Name .Like("%"+SearchValue+"%"));
            if(allBooks[i].Name .Like("%"+SearchValue+"%")){

            g = Instantiate (buttonTemplate, this.transform);
            g.transform.GetChild(0).gameObject.GetComponent <Text>().text = allBooks[i].Name;
            g.transform.GetChild(1).gameObject.GetComponent <Text>().text = allBooks[i].Author;
            if(allBooks[i].Availability == "yes"){
                g.transform.GetChild(2).gameObject.GetComponent <Image>().color = Color.green;
            }else{
                g.transform.GetChild(2).gameObject.GetComponent <Image>().color = Color.red;
            }
            // g.transform.GetChild(2).gameObject.GetComponent <Text>().text = allBooks[i].Availability;

            g.transform.GetChild(3).gameObject.GetComponent <Image>().sprite = allBooks[i].Cover;

            g.GetComponent <Button> ().AddEventListener (i, ItemClicked);

            }

           
         }
    }

}
