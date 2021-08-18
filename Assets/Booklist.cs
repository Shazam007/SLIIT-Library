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


    [Serializable]
    public struct Book{
        public string Name;
        public string Author;
        public string Availability;
        public Sprite Cover;
        public string category;
        public float X;
        public float Y;

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
		Debug.Log ("shelf location : " + allBooks[itemIndex].X + "," + allBooks[itemIndex].Y);
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
