using UnityEngine;

public class SmoothFollow2 : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + new Vector3(0f, 3f, -6f);
        transform.position = desiredPosition;
        transform.LookAt(target);
    }
}