using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;

public class GameContoller : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Text HiddenLetters;
    public UnityEngine.UI.Text LettersGuessed;

    public UnityEngine.UI.Text GuessesRem;

    public UnityEngine.UI.Text GuessInfo;
    public UnityEngine.UI.Button StartButton;

    public UnityEngine.UI.Button PlayAgain;

    public GameObject StartScreen;

    public GameObject PlayScreen;

    public GameObject GameOverScreen;

    private WordGuesser.WordGame guessingGame;

    public UnityEngine.UI.InputField PlayerGuess;


    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
    }

    public void OpenStartScreen()
    {
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }

    public void Start()
    {
        this.GameOverScreen.SetActive(false);
        this.StartScreen.SetActive(true);
        this.PlayScreen.SetActive(false);
    }

    public void SubmitGuess()
    {
        Debug.Log(this.guessingGame.CheckGuess(PlayerGuess.text));
        LettersGuessed.text = this.guessingGame.GetGuessedLetters();
        GuessesRem.text = $"{this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses()}";
        HiddenLetters.text = this.guessingGame.GetWord();
        GuessInfo.text = this.guessingGame.CheckGuess(PlayerGuess.text);
        PlayerGuess.text = string.Empty;
    }
}