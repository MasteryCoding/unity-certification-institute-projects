using UnityEngine;

public class Conditionals : MonoBehaviour
{
    void Start()
    {   

        // An if statement will run the code inside the curly braces
        // only if the value in the parentheses evaluates to true.
        bool isAlive = true;

        if (isAlive) {
            Debug.Log("Player is alive");
        }

        // An else statement lets us react to a false condition 
        // it will only execute the code in its curly braces if nothing above it runs.
        bool isTouchingGround = false;

        if (isTouchingGround) {
            Debug.Log("Player is touching ground.");
        } else {
            Debug.Log("Player is not touching ground.");
        }

        // An else if statement lets us check another condition 
        // it will only check if the ones above are false.
        int number = -3;

        if (number > 0) {
            Debug.Log("Number is positive!");
        } else if (number < 0) {
            Debug.Log("Number is negative!");
        } else {
            Debug.Log("Number is zero!");
        }
    }


}
