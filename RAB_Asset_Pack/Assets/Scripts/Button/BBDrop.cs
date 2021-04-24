using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BBDrop : ButtonBehaviour
{
  private Rigidbody rb;

  private void Awake() {
    rb = GetComponent<Rigidbody>();
  }

  private void Start() {
    rb.useGravity = false;
    rb.isKinematic = true;
  }

  override public void OnButtonDown() {
    rb.isKinematic = false;
    rb.useGravity = true;
  }
}
