using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BBAnimate : ButtonBehaviour
{
  private Animator animator;
  private void Awake() {
    animator = GetComponent<Animator>();
  }
  private void Start() {
    animator.enabled = false;
  }
  override public void OnButtonDown()
  {
    animator.enabled = true;
  }
}
