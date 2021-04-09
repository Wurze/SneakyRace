using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class StartGame : MonoBehaviour
{

    public float currentTime = 0f;
    public float startingTime = 3.0f;
    public Text startText; // used for showing countdown from 3, 2, 1 

    

    void Start()
    {
        Time.timeScale = 0.0f;
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= Time.unscaledDeltaTime;

        try
        {
            startText.text = (currentTime).ToString("0");
        }
        
        catch(NullReferenceException ex)
        {
            Debug.Log("text was not set");
        }


        if(currentTime < 1)
        {
            try
            {
                startText.text = "GO!";
            }
            
            catch(NullReferenceException ex)
            {
                Debug.Log("text was not set");
            }
        }
        
        if (currentTime <= 0)
        {
            Time.timeScale = 1f;

            removeText();
            
        }
    }

    void removeText()
    {
        try
        {
            startText.gameObject.SetActive(false);
        }
        catch (NullReferenceException ex)
        {
            Debug.Log("text was not set");
        }

    }
    
}
