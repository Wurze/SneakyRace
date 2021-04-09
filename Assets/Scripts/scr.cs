using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartScene()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}

