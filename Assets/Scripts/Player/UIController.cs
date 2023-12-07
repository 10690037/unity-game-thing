// michal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIController : MonoBehaviour
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
    public GameObject character;
    
    //variables
    bool menu = true;
    public int money = 200; // starter money
    int level = 0; // level
    int levelOfRobberies = 0; // amount of robberies
    bool settingsOpen = false;
    
    void Start(){
        // cursor
        SetCursorState(false);
        Cursor.visible = true;
        // activate panels
        MainPanel.SetActive(true);
        SettingsPanel.SetActive(false);
        InformationPanel.SetActive(false);
        // add listeners
        character = GameObject.FindWithTag("Player");
        PlayButton.onClick.AddListener(PlayClicked);
        ContinueButton.onClick.AddListener(PlayClicked);
        SettingsButton.onClick.AddListener(SettingsClicked);
        SettingsReturnButton.onClick.AddListener(SettingsClicked);
        QuitButton.onClick.AddListener(QuitGame);
        character.SetActive(false);
        // sets the information board
        string sMoney = money.ToString();
        MoneyText.text = sMoney;
    }

    // executed when play is pressed
    void PlayClicked(){
        MainPanel.SetActive(false);
        InformationPanel.SetActive(true);
        SetCursorState(true);
        menu = false;
        character.SetActive(true);
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
        // UnityEditor.EditorApplication.isPlaying = false; -- this was for the editor playview
        Application.Quit();
    }

    // activates cursor lock
    public void SetCursorState(bool hasFocus){
        if(hasFocus){
            Cursor.lockState = CursorLockMode.Locked;
        } else {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    void Update(){
        if(menu){
            // if on menu, unlock & turn on cursor
            SetCursorState(false);
            Cursor.visible = true;
        } else {
            //checks if the actual money value is the same as the ui one, if not update with a green effect crazy innit 
            string mText = MoneyText.text;
            Debug.Log(mText);
            mText = mText.Substring(1);
            if(int.Parse(mText) != money){
                MoneyText.text = "£"+money.ToString();
                MoneyText.color = new Color(0,230,0);
                MoneyText.color = new Color(255,255,255);
            }
            // if(MoneyText.text == money){
            //     string sMoney = money.ToString();
            //     MoneyText.text = "£"+sMoney;
            //     MoneyText.color = new Color(0,230,0);
            // }
        }
    }
}