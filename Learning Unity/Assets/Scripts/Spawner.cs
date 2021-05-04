
using UnityEngine;
// https://docs.unity3d.com/ScriptReference/Object.Instantiate.html


public class Spawner : MonoBehaviour
{
  public GameObject prefabToSpawn;
  void Start()
  {
    // Instantiate a GameObject at the origin using a prefab
    Instantiate(prefabToSpawn, new Vector3(0, 0, 0), Quaternion.identity);
  }
}


