using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject MainMenuPanel;
    public GameObject OptionsPanel;
    public GameObject CreditsPanel;
    public GameObject BankerPanel;
    public GameObject PausePanel;
    public GameObject InstructionsPanel;
    public GameObject GameSelectionPanel;
    public GameObject BlackjackPanel;
    public GameObject PokerPanel;
    public GameObject CrapsPanel;
    public GameObject RoulettePanel;
    public GameObject SlotsPanel;

    [Header("Sub-Panels")]
    public GameObject ConfirmationWindow;
    public GameObject InstPanel1;
    public GameObject InstPanel2;
    public GameObject InstPanel3;

    [Header("Other")]
    public eGames state = eGames.BlackJack;
    public GameController gameController;

    public enum eGames
    {
        BlackJack,
        Slots,
        Roulette,
        Poker,
        Craps
    }

    private void Start()
    {
        gameObject.SetActive(true);
<<<<<<< HEAD
        gameObjects.Add(MainMenuPanel);
        gameObjects.Add(OptionsPanel);
        gameObjects.Add(CreditsPanel);
        gameObjects.Add(BankerPanel);
        gameObjects.Add(PausePanel);
        gameObjects.Add(InstructionsPanel);
        gameObjects.Add(GameSelectionPanel);
        gameObjects.Add(BlackjackPanel);
        gameObjects.Add(PokerPanel);
        gameObjects.Add(CrapsPanel);
        gameObjects.Add(RoulettePanel);
        gameObjects.Add(SlotsPanel);
        gameObjects.Add(ConfirmationWindow);
        gameObjects.Add(InstPanel1);
        gameObjects.Add(InstPanel2);
        gameObjects.Add(InstPanel3);

        Disable();
        MainMenuPanel.SetActive(true);
=======
>>>>>>> parent of bfe0a84... Improved Entire UI
        GameController.Instance.state = eState.TITLE;
    }
    private void StartGame()
    {
        MainMenuPanel.SetActive(false);
        PausePanel.SetActive(false);
        ConfirmationWindow.SetActive(false);
        BankerPanel.SetActive(false);
        GameController.Instance.state = eState.GAME;
        Debug.Log("Start Game");
    }

    public void BlackJack_Selection()
    {
        state = eGames.BlackJack;
    }

    public void Slots_Selection()
    {
        state = eGames.Slots;
    }

    public void Roulette_Selection()
    {
        state = eGames.Roulette;
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
            if (state == eGames.BlackJack)
            {
                Disable();
                InstructionsPanel.SetActive(true);
                InstPanel1.SetActive(true);
            }
            else if (state == eGames.Slots)
            {
                Disable();
                InstructionsPanel.SetActive(true);
                InstPanel2.SetActive(true);
            }
            else if (state == eGames.Roulette)
            {
                Disable();
                InstructionsPanel.SetActive(true);
                InstPanel3.SetActive(true);
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

        InstPanel1.SetActive(false);
        InstPanel2.SetActive(false);
        InstPanel3.SetActive(false);
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
        GameSelectionPanel.SetActive(false);
        ConfirmationWindow.SetActive(false);
        GameController.Instance.state = eState.TITLE;
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
        GameSelectionPanel.SetActive(false);
        ConfirmationWindow.SetActive(false);
        GameController.Instance.state = eState.PAUSE;
    }

    public void Play_Blackjack()
    {
        BlackjackPanel.SetActive(true);
        StartGame();
    }

    public void Play_Slots()
    {
        SlotsPanel.SetActive(true);
        StartGame();
    }

    public void Play_Roulette()
    {
        RoulettePanel.SetActive(true);
        StartGame();
    }

    public void Play_Poker()
    {
        //Nothing
    }

    public void Play_Craps()
    {
        //Nothing
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