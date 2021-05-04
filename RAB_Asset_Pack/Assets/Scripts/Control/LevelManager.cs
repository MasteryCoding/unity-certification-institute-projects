using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
  [HideInInspector] public List<Coin> collectables;
  [HideInInspector] public GameObject player;
  [HideInInspector] public static LevelManager singleton;
  int coinsCollected = 0;

  // Start is called before the first frame update
  void Awake()
  {
    if (LevelManager.singleton != null)
    {
      Destroy(this);
      return;
    }
    LevelManager.singleton = this;
    GetCollectables();
    GetPlayer();
  }

  public void Collect(Coin coin)
  {
    Destroy(coin.gameObject);
    collectables.Remove(coin);
    coinsCollected++;
  }

  void GetCollectables()
  {
    foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Coin"))
    {
      Coin coin = obj.GetComponent<Coin>();
      if (coin == null)
      {
        Debug.LogWarning(obj.name + " does not have a Coin component.");
        continue;
      }
      collectables.Add(coin);
    }
  }

  void GetPlayer()
  {
    // Get the player in the scene.
    GameObject[] playerCandidates = GameObject.FindGameObjectsWithTag("Player");
    if (playerCandidates.Length == 0)
    {
      throw new System.Exception("No GameObject with player tag in scene.");
    }
    if (playerCandidates.Length > 1)
    {
      throw new System.Exception("More than one player in scene.");
    }
    player = playerCandidates[0];
  }

}
