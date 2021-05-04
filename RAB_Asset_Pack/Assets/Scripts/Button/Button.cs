using UnityEngine;

// Topics
// Inheritance, Triggers
public class Button : MonoBehaviour
{
  public ButtonBehaviour[] buttonBehaviours;
  public Color color;

  private void Start() {
    GetComponent<Renderer>().material.color = color;
  }

  private void OnTriggerEnter() {
    foreach (ButtonBehaviour b in buttonBehaviours) {
      b.OnButtonDown();
    }
  }

  private void OnTriggerExit()
  {
    foreach (ButtonBehaviour b in buttonBehaviours)
    {
      b.OnButtonUp();
    }
  }

  private void OnDrawGizmos() {
    foreach (ButtonBehaviour b in buttonBehaviours)
    {
      Debug.DrawLine(transform.position, b.transform.position, color);
    }
  }
}
