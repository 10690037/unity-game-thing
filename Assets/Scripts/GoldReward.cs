using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldReward : MonoBehaviour, IInteractable {
    // [SerializeField] public text MoneyText;
    public void Interact(){
        // string money = MoneyText.text;
        // money = money.Substring(1,1);
        // Debug.Log(money);
        Destroy(gameObject);
    }
}
