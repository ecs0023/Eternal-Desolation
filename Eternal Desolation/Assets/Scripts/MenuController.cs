using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //These commands control the buttons of the UI
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void EndGame()
    {
        Debug.Log("End Game");
    }
    public void LoadScene2()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadScene4()
    {
        SceneManager.LoadScene(4);
    }
}

