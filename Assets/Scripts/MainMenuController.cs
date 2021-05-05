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
    public GameObject BankerPanel;
    public GameObject PausePanel;
    public GameObject ConfirmationWindow;
    public GameObject InstructionsPanel;
    public GameObject GameSelectionPanel;
    public GameObject BlackJack;
    public GameObject Poker;
    public GameObject Craps;
    public GameObject Roulette;
    public GameObject Slots;
    public GameObject InstPanel1;
    public GameObject InstPanel2;
    public GameObject InstPanel3;
    public int swapVal = 0;

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
        BankerPanel.SetActive(false);
        GameController.Instance.state = eState.GAME;
        Debug.Log("Start Game");
    }

    public void GameSelection()
    {
        MainMenuPanel.SetActive(false);
        ConfirmationWindow.SetActive(false);
        GameSelectionPanel.SetActive(true);
        GameController.Instance.state = eState.MENU;
    }

    public void InstructionsPanelSwap()
    {
        if (GameController.Instance.state == eState.INSTRUCTIONS)
        {
            //Swap different Panels based on a value
            if (swapVal == 1)
            {

                swapVal = 0;
            }
            else if (swapVal == 2)
            {

                swapVal = 0;
            }
            else if (swapVal == 3)
            {

                swapVal = 0;
            }
        }
    }

    public void StartGameSettings1()
    {
        MainMenuPanel.SetActive(false);
        BankerPanel.SetActive(false);
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

    public void Instructions()
    {
        InstructionsPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
        GameController.Instance.state = eState.INSTRUCTIONS;
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
            InstructionsPanel.SetActive(false);
            BankerPanel.SetActive(false);
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
        InstructionsPanel.SetActive(false);
        BankerPanel.SetActive(false);
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
        InstructionsPanel.SetActive(false);
        BankerPanel.SetActive(false);
        GameController.Instance.state = eState.PAUSE;
        Console.WriteLine("BacktoPause menu controller");
    }

    public void Banker()
    {
        BankerPanel.SetActive(true);
        GameController.Instance.state = eState.MENU;
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
