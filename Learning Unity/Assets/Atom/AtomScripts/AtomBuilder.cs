using UnityEngine;

public class AtomBuilder : MonoBehaviour
{
  public GameObject electron;
  public int electronCount = 1;
  public float radius = 5;

  Vector3 rotationAxis;

  void Start() {
    for (int i = 0; i < electronCount; i++) {
      Instantiate(electron, transform.position, Random.rotation);
    }
  }
}
