using UnityEngine;

public class InteractionButton : MonoBehaviour
{
  public ButtonBehaviour[] buttonBehaviours;

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
}
