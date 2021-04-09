using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Times Tables (3)
        Debug.Log(3 * 0);
        Debug.Log(3 * 1);
        Debug.Log(3 * 2);
        Debug.Log(3 * 3);
        Debug.Log(3 * 4);
        Debug.Log(3 * 5);
        Debug.Log(3 * 6);
        Debug.Log(3 * 7);
        Debug.Log(3 * 8);

        // While loops require tracking the exit condition
        int times = 0;

        while (times < 9) {
            Debug.Log(3 * times);
        }

        // For loops are good for running a set amount of times.
        // A for loop head has three parts:
        // 1. initialization
        // 2. checking a condition
        // 3. incrementing / decrementing
        for (int i = 0; i < 9; i++) {
            Debug.Log(3 * i);
        }

        // Break
        for (int i = 0; i < 9; i++) {
            if (i == 5) {
                break;
            }
            Debug.Log(i);
        }

        // Continue
        for (int i = 0; i < 9; i++) {
            if (i % 2 == 0) {
                continue;
            }
            Debug.Log(i);
        }
        
    }
}