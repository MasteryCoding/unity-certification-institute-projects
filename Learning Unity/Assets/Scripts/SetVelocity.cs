using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SetVelocity : MonoBehaviour
{
  [SerializeField] Vector3 _velocity;
  Rigidbody rb;
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    rb.isKinematic = false;
    rb.useGravity = false;
  }
  void FixedUpdate() {
    rb.velocity = _velocity;
  }
}
