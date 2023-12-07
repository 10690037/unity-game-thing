using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldReward : MonoBehaviour, IInteractable {
    [SerializeField] private GameObject Canvas;
    public UIController uiController;

    public void Interact(){
        uiController = Canvas.GetComponent<UIController>();
        uiController.money = uiController.money + 168000;
        Destroy(gameObject);
    }
}