
using UnityEngine;

public class OOP : MonoBehaviour {

  void Start() {
    
    Person beatrice = new Person("Beatrice Wyld", 34);
    Person mike = new Person("Michael Bernstein", 34);

    Person.HandShake(beatrice, mike);

    mike.SayHello();
  }

}