using UnityEngine;

public class Methods : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Passing in arguments
        int number = 8;
        int result = addTwoNumbers(5, number);

        // Separating complex code
        int[] numbers = {-32, 43, 21, 33, 11, 76, -43, -12};

        Debug.Log("The largest number is: " + FindLargestNumber(numbers));
        Debug.Log("The sum of the numbers is: " + Sum(numbers));
    }

    int addTwoNumbers(int a, int b) {
        return a + b;
    }

    int Sum(int[] numbers) {
        int sum = 0;
        foreach (int number in numbers) {
            sum += number; 
        }
        return sum;
    }

    int FindLargestNumber(int[] numbers) {
        int king = 0;
        foreach (int number in numbers) {
            if (number > king) {
                king = number;
            } 
        }
        return king;
    }

    void sayHello() {
        Debug.Log("Hello World!");
    }

}
