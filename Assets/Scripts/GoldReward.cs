using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldReward : MonoBehaviour, IInteractable {
    public GameObject PlayerCapsule;
    public UIController uiController;

    public void Interact(){
        PlayerCapsule = GameObject.FindWithTag("Player");
        uiController = PlayerCapsule.GetComponent<UIController>();
        uiController.money = uiController.money + 2000;
        Destroy(gameObject);
    }
}