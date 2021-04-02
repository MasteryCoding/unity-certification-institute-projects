using UnityEngine;
public class OurFirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Logs the message string "Hello World" to the console
        Debug.Log("Hello World");

        // Logs the warning string "Be careful here" to the console
        Debug.LogWarning("Be careful here...");

        // Logs the error string "This is wrong!" to the console
        Debug.LogError("This is wrong!");

        // Logging other Data Types
        Debug.Log(45); // Logs an int
        Debug.Log(4.5f); // Logs a float
        Debug.Log(true); // Logs a bool
    }
}
