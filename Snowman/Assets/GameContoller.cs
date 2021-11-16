using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContoller : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;

    public void StartGame()
    {
        this.Message.text = "Can you save the Snowman";
        this.StartButton.gameObject.SetActive(false);
    }
}