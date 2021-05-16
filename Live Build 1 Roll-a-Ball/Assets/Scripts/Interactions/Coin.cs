using UnityEngine;

public class Coin : MonoBehaviour
{

  private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Player"))
    {
      GameManager.am.Play("Coin");
      // Destroys self if it collides with a player.
      Destroy(gameObject);
    }
  }

}