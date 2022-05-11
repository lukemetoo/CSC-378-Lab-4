using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Overview : MonoBehaviour
{

    public string newGameScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Main_Menu() {
        SceneManager.LoadScene(newGameScene);
    }
}
