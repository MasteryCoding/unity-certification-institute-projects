using UnityEngine;

public class Killbox : MonoBehaviour
{
  public Transform respawn;
  private void OnTriggerEnter(Collider other)
  {
    if (!other.CompareTag("Player")) return;

    Rigidbody rb = other.GetComponent<Rigidbody>();


    // Reset Rigidbody
    rb.velocity = Vector3.zero;
    rb.angularVelocity = Vector3.zero;
    other.transform.rotation = Quaternion.Euler(Vector3.zero);

    other.transform.position = respawn.position;
  }
}
