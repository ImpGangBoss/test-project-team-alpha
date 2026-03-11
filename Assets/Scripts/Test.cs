using UnityEngine;

public class Test : MonoBehaviour
{
    void Awake() 
    {
        Debug.Log("Test script is awakening!");
    }

    void Start()
    {
        Debug.Log("Test script is running!");
        Debug.LogWarning("This is a warning message.");
        Debug.LogError("This is an error message.");

        Debug.Log(Time.fixedDeltaTime);
    }

    void OnEnable() 
    {
        Debug.Log("Test script has been enabled.");
    }

    void OnDisable() 
    {
        Debug.Log("Test script has been disabled.");
    }
}
