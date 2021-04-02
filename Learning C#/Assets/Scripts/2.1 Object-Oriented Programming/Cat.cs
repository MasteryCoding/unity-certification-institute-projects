using UnityEngine;

public class Cat : MonoBehaviour {
  public string catName;
  public bool hasFur;
  public string furColor;
  public int age;
  public string favoriteFood;

  void Start() {
    Debug.Log(Introduce());
  }

  string Introduce() {
    string sentence = "This is " + catName + ". ";
    if (hasFur) {
      sentence += name + " has " + furColor + " fur. ";
    } else {
      sentence += name + "is hairless, ";
    }
    sentence += age + " years old, ";
    sentence += "and loves to eat " + favoriteFood;
    return sentence;
  }
}