// michal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class NPlayerController : MonoBehaviour
{
    // main menu and associated fields
    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private Button PlayButton;
    [SerializeField] private Button ContinueButton;
    [SerializeField] private Button SettingsButton;
    [SerializeField] private Button SettingsReturnButton;
    [SerializeField] private Button QuitButton;

    // in-game information
    [SerializeField] private GameObject InformationPanel;
    [SerializeField] private Text MoneyText;

    // character
    [SerializeField] private GameObject Character;
    
    //variables
    int money = 200; // starter money
    int level = 0; // level
    int levelOfRobberies = 0; // amount of robberies
    bool settingsOpen = false;
    
    void Start(){
        // unlocks the cursor
        SetCursorState(false);
        // activate panels
        MainPanel.SetActive(true);
        SettingsPanel.SetActive(false);
        InformationPanel.SetActive(false);
        // add listeners
        PlayButton.onClick.AddListener(PlayClicked);
        ContinueButton.onClick.AddListener(PlayClicked);
        SettingsButton.onClick.AddListener(SettingsClicked);
        SettingsReturnButton.onClick.AddListener(SettingsClicked);
        QuitButton.onClick.AddListener(QuitGame);
        // sets the information board
        string sMoney = money.ToString();
        MoneyText.text = "£"+sMoney;
    }

    // executed when play is pressed
    void PlayClicked(){
        MainPanel.SetActive(false);
        InformationPanel.SetActive(true);
        SetCursorState(true);
    }

    // executed when settings is pressed
    void SettingsClicked(){
        if(settingsOpen == false){
            settingsOpen = true;
            MainPanel.SetActive(false);
            SettingsPanel.SetActive(true);
        } else {
            settingsOpen = false;
            MainPanel.SetActive(true);
            SettingsPanel.SetActive(false);
        }
    }

    // executed when quit is pressed
    public void QuitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    // activates cursor lock
    public void SetCursorState(bool hasFocus){
        Cursor.lockState = true ? CursorLockMode.Locked : CursorLockMode.None;
    }

    void Update(){
        
    }
}