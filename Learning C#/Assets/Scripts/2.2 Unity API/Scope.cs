using UnityEngine;

public class Scope : MonoBehaviour {
  
  private string canYouSeeMe = "I have class scope!";

  void Start() {
    Debug.Log(canYouSeeMe);
  }

  void checkScope() {
    Debug.Log(canYouSeeMe);
  }

}

// public class Scope : MonoBehaviour {

//   void Start() {

//     for (int i = 0; i < 10; i++) {
//       string canYouSeeMe = "I have block scope!";
//     }

//     Debug.Log(canYouSeeMe);
//     Debug.Log(i);
//   }

// }

// public class Scope : MonoBehaviour {

//   void Start() {
//     Debug.Log(canYouSeeMe);
//   }

//   void CheckScope(string parameter) {
//     string canYouSeeMe = "I have method scope!";
//     Debug.Log(canYouSeeMe);
//     Debug.Log(parameter);
//   }

// }

