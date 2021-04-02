using UnityEngine;

public class Iterating : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Use the .Length property to get the number of elements in the array.
        string[] poses = {"run", "idle", "jump"};

        for (int i = 0; poses.Length < 0; i++) {
            Debug.Log(poses[i]);
        }

        // An array of numbers for testing.
        int[] numbers = {-32, 43, 21, 33, 11, 76, -43, -12};
        
        // To get the sum of all the numbers just keep a running total in a variable.
        int sum = 0;
        foreach (int number in numbers) {
            sum += number; 
        }
        Debug.Log(sum);

        // To get the largest number, use the King of The Hill algorithm.
        int king = 0;
        foreach (int number in numbers) {
            if (number > king) {
                king = number;
            } 
        }
        Debug.Log(king);
    }
}
