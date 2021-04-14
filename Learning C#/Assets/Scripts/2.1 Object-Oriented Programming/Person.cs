using UnityEngine;

public class Person {
  public string name;
  public int age;

  public Person(string _name, int _age) {
    name = _name;
    age = _age;
  }
  public void SayHello() {
    Debug.Log("Hello, my name is " + name + ". I am " + age + " years old.");
  }

  public static void HandShake(Person p1, Person p2) {
    Debug.Log(p1.name + " is shaking " + p2.name + "'s hand.");
  }
}