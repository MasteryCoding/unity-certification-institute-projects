using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

    Vector3 vector1 = new Vector3(1, -2, 4);
    Vector3 vector2 = new Vector3(2, 3, 1);
    float scalar = 0.5f;

    // Access individual component values
    float xComponent = vector1.x; 

    // The length of the vector as a property
    float magnitude = vector2.magnitude; 

    // Addition works just like scalars
    Vector3 sum = vector1 + vector2;

    // Multiplication between a vector and a scalar
    Vector3 scaledVector = vector1 * scalar;

    // Public methods are used on the instance
    string vectorAsAString = vector1.ToString();

    // Static Method Distance() accessed through the class
    float distanceBetweenTwoPoints = Vector3.Distance(vector1, vector2);
  }
}
