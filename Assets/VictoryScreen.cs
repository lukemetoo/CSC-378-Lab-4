using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{

    public string newGameScene;
    public string creditsScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startOver() {
        SceneManager.LoadScene(newGameScene);
    }

    public void credits() {
        SceneManager.LoadScene(creditsScene);
    }
}
