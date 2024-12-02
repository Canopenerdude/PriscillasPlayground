using UnityEngine;

public class DisappearObject : MonoBehaviour
{
    public float disappearTime = 3f; // Time after which the object will disappear

    void Start()
    {
        // Call the Disappear method after a delay
        Invoke("Disappear", disappearTime);
    }

    void Disappear()
    {
        // Disable the GameObject (the object will disappear)
        gameObject.SetActive(false);
    }
}