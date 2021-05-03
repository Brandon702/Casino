using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject OptionsPanel;
    public GameObject CreditsPanel;
    public GameObject GameOverPanel;
    public GameObject PausePanel;
    public GameObject ConfirmationWindow;
    public GameObject InstructionsPanel1;
    public GameObject InstructionsPanel2;
    public GameObject InstructionsPanel3;
    public GameObject InstructionsPanel4;
    public GameObject InstructionsPanel5;
    public GameObject BlackJack;
    public GameObject Poker;
    public GameObject Craps;
    public GameObject Roulette;
    public GameObject Slots;
    public GameController gameController;

    private void Start()
    {
        gameObject.SetActive(true);
        GameController.Instance.state = eState.TITLE;
    }
    public void StartGame()
    {
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
        ConfirmationWindow.SetActive(false);
        GameOverPanel.SetActive(false);
        GameController.Instance.state = eState.GAME;
        Debug.Log("Start Game");
    }

    public void StartGameSettings1()
    {
        MainMenuPanel.SetActive(false);
        GameOverPanel.SetActive(false);
        ConfirmationWindow.SetActive(true);
        GameController.Instance.state = eState.MENU;
        Debug.Log("Settings1 menu");
    }

    public void Options()
    {
        OptionsPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
        Debug.Log("Options menu");
    }

    public void Instructions1()
    {
        InstructionsPanel1.SetActive(true);
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
    }

    public void Instructions2()
    {
        InstructionsPanel2.SetActive(true);
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
    }

    public void Instructions3()
    {
        InstructionsPanel3.SetActive(true);
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
    }

    public void Instructions4()
    {
        InstructionsPanel4.SetActive(true);
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
    }

    public void Instructions5()
    {
        InstructionsPanel5.SetActive(true);
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
    }

    public void Credits()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        PausePanel.SetActive(false);
        Debug.Log("Credits menu");
    }

    public void Back()
    {
        if (GameController.Instance.state == eState.PAUSE)
        {
            BackToPause();
        }
        else
        {
            BackToMenu();
        }
    }

    public void Pause()
    {
        if (GameController.Instance.state == eState.GAME)
        {
            PausePanel.SetActive(true);
            MainMenuPanel.SetActive(false);
            OptionsPanel.SetActive(false);
            CreditsPanel.SetActive(false);
            InstructionsPanel1.SetActive(false);
            InstructionsPanel2.SetActive(false);
            InstructionsPanel3.SetActive(false);
            InstructionsPanel4.SetActive(false);
            InstructionsPanel5.SetActive(false);
            GameOverPanel.SetActive(false);
            GameController.Instance.state = eState.PAUSE;
        }
    }

    //Back to main menu
    public void BackToMenu()
    {
        //gameObject.SetActive(false);
        MainMenuPanel.SetActive(true);
        PausePanel.SetActive(false);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        InstructionsPanel1.SetActive(false);
        InstructionsPanel2.SetActive(false);
        InstructionsPanel3.SetActive(false);
        InstructionsPanel4.SetActive(false);
        InstructionsPanel5.SetActive(false);
        GameOverPanel.SetActive(false);
        ConfirmationWindow.SetActive(false);
        GameController.Instance.state = eState.TITLE;
        Console.WriteLine("BacktoMenu menu controller");
    }

    //Back to pause menu
    public void BackToPause()
    {
        PausePanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        OptionsPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        InstructionsPanel1.SetActive(false);
        InstructionsPanel2.SetActive(false);
        InstructionsPanel3.SetActive(false);
        InstructionsPanel4.SetActive(false);
        InstructionsPanel5.SetActive(false);
        GameOverPanel.SetActive(false);
        GameController.Instance.state = eState.PAUSE;
        Console.WriteLine("BacktoPause menu controller");
    }

    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        GameController.Instance.state = eState.MENU;
        Console.WriteLine("Gameover menu controller");
    }

    public void ResetApplication()
    {
        SceneManager.LoadScene("Pente");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
