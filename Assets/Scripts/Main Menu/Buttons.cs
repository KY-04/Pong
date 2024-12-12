using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    //for the Options Panel
    public GameObject OptionsPanel;

    //for the Credits  
    public GameObject Credits;

    //for the Credits Panel 
    public GameObject BackToMain;

    private void Start()
    {
        //This is to hide the Options panel when the game starts
        OptionsPanel.SetActive(false);

        Credits.SetActive(false);
    }
    // Start is called before the first frame update
    public void PlayerVsAI()
    {
        //This will take you to the player vs ai scene
        SceneManager.LoadScene(1);

        Debug.Log("Starting Player Vs AI");
    }

    public void PlayerVsPlayer()
    {
        //This will take you to the player vs Player scene
        SceneManager.LoadScene(2);

        Debug.Log("Starting Player Vs Player");

    }

    public void Exit()
    {
        Application.Quit();

        //Debugging purposes

        Debug.Log("Quitting Pong");
    }

    public void OptionsButton()
    {
        //If you click the how to play button
        //Instruction will open

        OptionsPanel.SetActive(true);
        Credits.SetActive(false);

        Debug.Log("Opening Options");

    }

    public void CreditsPanel()
    {
        //If player pressed quit button in the panel
        //Instruction Menu will disappear

        Credits.SetActive(true);

        Debug.Log("Opening Credits");

    }

    public void ExitOptions()
    {
        //When Clicking this button
        //it will close up the options panel
        OptionsPanel.SetActive(false);
        Credits.SetActive(false);

        Debug.Log("Closing Options");
    }
}
