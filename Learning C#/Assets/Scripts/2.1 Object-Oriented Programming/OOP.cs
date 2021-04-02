
using UnityEngine;

public class OOP : MonoBehaviour {

  void Start() {
    Person mike = new Person("Michael Bernstein", 34);
    mike.SayHello();
  }

}