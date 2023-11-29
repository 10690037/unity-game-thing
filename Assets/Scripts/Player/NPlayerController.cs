using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPlayerController : MonoBehaviour
{
    [SerializeField] private GameObject MainPanel;
    [SerializeField] private Button PlayButton;
    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(PlayClicked);
    }

    void PlayClicked()
    {
        MainPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
