using UnityEngine;

public class Killbox : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    if (!other.CompareTag("Player")) return;
    other.GetComponent<Movement>().Respawn();
  }
}
