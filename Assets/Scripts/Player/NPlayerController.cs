using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPlayerController : MonoBehaviour
{
    [SerializeField] private GameObject MainPanel;
    [SerializeField] private Button PlayButton;
    [SerializeField] private Button ContinueButton;
    [SerializeField] private Button SettingsButton;
    [SerializeField] private Button QuitButton;

    settingsOpen = false
    
    // Start is called before the first frame update
    void Start(){
        PlayButton.onClick.AddListener(PlayClicked);
        ContinueButton.onClick.AddListener(PlayClicked);
        SettingsButton.onClick.AddListener(PlayClicked);
        QuitButton.onClick.AddListener(QuitGame);
    }

    void PlayClicked(){
        MainPanel.SetActive(false);
    }

    void SettingsClicked(){

    }

    public void QuitGame(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}