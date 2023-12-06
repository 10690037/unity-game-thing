using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldReward : MonoBehaviour, IInteractable {
    public GameObject PlayerCapsule;
    public UIController script;

    public void Interact(){
        // string money = MoneyText.text;
        // money = money.Substring(1,1);
        // Debug.Log(money);
        PlayerCapsule = GameObject.FindWithTag("Player");
        Debug.Log(UIController.money);
        // Script = PlayerCapsule.GetComponent<UIController>();
        // Debug.Log(Script.money);
        // Debug.Log("Name"+PlayerCapsule.name);
        // public ScriptComponents[] scriptComponents;
        // scriptComponents = PlayerCapsule.GetComponents<Script>();
        // int money = ScriptComponents[3].Money;
        // money = money + 2000;
        // Debug.Log(money);
        Destroy(gameObject);
    }
}