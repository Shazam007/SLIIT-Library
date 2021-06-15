using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenuScript : MonoBehaviour
{

    public void StartApp()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void EndApp()
    {
        Application.Quit();
    }

    public void replayApp()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
