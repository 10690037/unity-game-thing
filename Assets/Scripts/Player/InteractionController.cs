using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable {
    public void Interact();
}

public class InteractionController : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            Debug.Log("Pressed");
            Ray detectRay = new Ray(InteractorSource.position, InteractorSource.forward);
            if(Physics.Raycast(detectRay, out RaycastHit hitInfo, InteractRange)){
                Debug.Log("2");
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj)){
                    Debug.Log("3");
                    interactObj.Interact();
                }
            }
        }
    }
}
