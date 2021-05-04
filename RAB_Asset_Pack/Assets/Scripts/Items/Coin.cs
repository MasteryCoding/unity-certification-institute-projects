using UnityEngine;

public class Coin : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    Debug.Log("Collided");
    if (other.CompareTag("Player"))
    {
      LevelManager.singleton.Collect(this);
    }
  }
}
