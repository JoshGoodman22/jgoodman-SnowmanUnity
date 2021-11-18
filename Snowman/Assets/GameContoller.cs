using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContoller : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;

    public gameObject StartScreen;

    public gameObject Playscreen;

    public void StartGame()
    {
        this.Message.text = "Can you save the Snowman";
        this.StartButton.gameObject.SetActive(false);
        this.StartScreen.SetActive(false);
        this.Playscreen.SetActive(true);
    }
    
    public void OpenStartScreen()
    {
        this.StartGame.SetActive(true);
        this.StartScreen.SetActive(false;
    }
    
    
}