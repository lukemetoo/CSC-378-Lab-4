using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string newGameScene;
    public string overviewGameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame() {
        SceneManager.LoadScene(newGameScene);
    }

    public void Overview() {
        SceneManager.LoadScene(overviewGameScene);
    }

    public void quit() {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
