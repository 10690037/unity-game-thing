using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldReward : MonoBehaviour, IInteractable {
    public void Interact(){
        Debug.Log("clicked");
        Destroy(gameObject);
    }
}
