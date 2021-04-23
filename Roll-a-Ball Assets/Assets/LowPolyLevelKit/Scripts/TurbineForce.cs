using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TurbineForce : MonoBehaviour
{
  Collider col;
  private void Awake()
  {
    col = GetComponent<Collider>();
  }

  void OnTriggerStay(Collider other) {
    Rigidbody rb = other.GetComponent<Rigidbody>();
    if (rb == null || !rb.useGravity) return;
    rb.AddForce(0,15,0, ForceMode.Force);
    // rb.AddForce(0, 0.5f, 0, ForceMode.Impulse);
  }

}
