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
    
    int money = 0;
    bool settingsOpen = false;
    
    void Start(){
        MainPanel.SetActive(true);
        SettingsPanel.SetActive(false);
        InformationPanel.SetActive(false);
        PlayButton.onClick.AddListener(PlayClicked);
        ContinueButton.onClick.AddListener(PlayClicked);
        SettingsButton.onClick.AddListener(SettingsClicked);
        SettingsReturnButton.onClick.AddListener(SettingsClicked);
        QuitButton.onClick.AddListener(QuitGame);
        string sMoney = money.ToString();
        MoneyText.text = "£"+sMoney;
    }

    void PlayClicked(){
        MainPanel.SetActive(false);
        InformationPanel.SetActive(true);
        SetCursorState(true);
    }

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

    public void QuitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    private void OnApplicationFocus(bool hasFocus){
        SetCursorState(true);
    }

    private void SetCursorState(bool newState){
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }

    void Update(){
        
    }
}