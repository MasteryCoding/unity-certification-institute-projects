using UnityEngine;

public class ChangeColor : MonoBehaviour
{
  public Color color;
  // Start is called before the first frame update
  void Start()
  {
    Renderer[] gateBlocks = GetComponentsInChildren<Renderer>();
    foreach(Renderer block in gateBlocks) {
      SetColor(block);
    }
  }

  void SetColor(Renderer renderer) {
    if (renderer == null) {
      Debug.LogError("Object with no renderer collided with ColorChanger.");
      return;
    }
    renderer.material.color = color;
  }

  void OnTriggerEnter(Collider other) {
    SetColor(other.GetComponent<Renderer>());
  }
}
