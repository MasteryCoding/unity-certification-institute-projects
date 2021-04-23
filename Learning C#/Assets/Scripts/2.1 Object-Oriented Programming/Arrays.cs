using UnityEngine;

public class Arrays : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // Lists of items are difficult to work with using variables
    // string item1 = "Lemons";
    // string item2 = "Veggie Dogs";
    // string item3 = "Aluminum Foil";
    // string item4 = "Ping Pong Paddle";
    // string item5 = "3 Cheeses";
    // string item6 = "Tomatoes";
    // string item7 = "Celery";
    // string item8 = "Pizza Cutter";
    // string item9 = "Chocolate";
    // string item10 = "Hot Chips";

    // Debug.Log(item1);
    // Debug.Log(item2);
    // Debug.Log(item3);
    // Debug.Log(item4);
    // Debug.Log(item5);
    // Debug.Log(item6);
    // Debug.Log(item7);
    // Debug.Log(item8);
    // Debug.Log(item9);
    // Debug.Log(item10);

    // Arrays make this easier
    string[] groceries = { "Lemons", "Veggie Dogs", "Aluminum Foil" };

    // ["Lemons", "Veggie Dogs", "Aluminum Foil"]
    
    string[] arrayCopy = groceries;

    groceries[0] = "Apples";
    arrayCopy[2] = "Celery";

    // ["Apples", "Veggie Dogs", "Celery"]

    Debug.Log(groceries[1]); // Access the element at index 1

    groceries[2] = "Gold Foil"; // Replace the element at index 2


    // Runtime array allocation with "new" keyword
    string[] animals;
    animals = new string[] { "Dog", "Cat", "Bird" };

    // Initialize Empty Array and fill in elements later.
    float[] testScores = new float[20];

    testScores[3] = 45.6f;
    testScores[10] = 99.4f;





  }
}
